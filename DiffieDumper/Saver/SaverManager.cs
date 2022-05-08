using System.Buffers.Binary;
using DiffieDumper.Net;
using DiffieDumper.Sulek;
using Microsoft.Extensions.Logging;
using Serilog;
using DiffieDumper.Utils;

namespace DiffieDumper.Saver;

public record SaverTaskData(string ServerIp);

public class SaverManager : IAsyncDisposable
{
    private const int ExpectedParameterLength = 512;
    
    private readonly LibraryManager _library;
    private readonly SaverQueue _queue;
    private readonly CancellationTokenSource _cancellationDump;
    private readonly CancellationTokenSource _cancellationWrite;
    private readonly ILoggerFactory _loggerFactory;

    private Task? _saveTask;
    private List<Task>? _dumpTasks;

    public SaverManager(LibraryManager library)
    {
        _library = library;
        _queue = new SaverQueue(Constants.WriteQueueCapacity);
        _cancellationDump = new CancellationTokenSource();
        _cancellationWrite = new CancellationTokenSource();
        _loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.SetMinimumLevel(LogLevel.Warning);
            builder.AddSerilog();
        });
    }

    /// <summary>
    ///     Spin up <see cref="HabClient"/>s and the <see cref="SaveAsync"/> task.
    /// </summary>
    public async Task RunAsync()
    {
        _saveTask = SaveAsync();
        _dumpTasks = new List<Task>();
        
        foreach (var serverIp in Constants.HabboServers)
        {
            _dumpTasks.Add(DumpAsync(serverIp));
        }

        await Task.WhenAll(_dumpTasks);
    }

    private async Task DumpAsync(string serverIp)
    {
        var data = new SaverTaskData(serverIp);
        var options = new ParallelOptions
        {
            MaxDegreeOfParallelism = Constants.DumpConcurrency,
            CancellationToken = _cancellationDump.Token
        };

        try
        {
            await Parallel.ForEachAsync(Enumerable.Repeat(data, Constants.DumpTotal), options, DumpClientAsync);
        }
        catch (OperationCanceledException)
        {
            // Ignore.
        }
    }

    // To avoid closure capture, just in case.
    private async ValueTask DumpClientAsync(SaverTaskData data, CancellationToken token)
    {
        var client = new HabClient(_library, _queue, _loggerFactory);
            
        Log.Verbose("Dumping");
        await client.DumpAsync(data.ServerIp, token);
        Log.Verbose("Exit");
    }

    /// <summary>
    ///     Write results from the <see cref="HabClient"/>s to a file.
    /// </summary>
    private async Task SaveAsync()
    {
        var fileName = $"session_{DateTimeOffset.UtcNow.ToUnixTimeSeconds()}.dat";

        await using var output = File.Open(fileName, FileMode.CreateNew, FileAccess.Write, FileShare.Read);
        
        try
        {
            var counter = 0U;
            var buffer = new byte[1024];

            while (!_cancellationWrite.IsCancellationRequested)
            {
                // Process queue.
                var item = await _queue.DequeueAsync(_cancellationWrite.Token);
                
                // Sanity check.
                if (string.IsNullOrEmpty(item.EncryptedGenerator) ||
                    string.IsNullOrEmpty(item.EncryptedPrime) ||
                    string.IsNullOrEmpty(item.EncryptedPublicKey))
                {
                    Log.Warning("Invalid queue item, empty parameters");
                    continue;
                }

                if (item.EncryptedGenerator.Length != ExpectedParameterLength)
                {
                    Log.Warning("Invalid queue item, EncryptedGenerator length ({Actual} != {Expected})",
                        item.EncryptedGenerator.Length,
                        ExpectedParameterLength);
                    continue;
                }

                if (item.EncryptedPrime.Length != ExpectedParameterLength)
                {
                    Log.Warning("Invalid queue item, EncryptedPrime length ({Actual} != {Expected})",
                        item.EncryptedPrime.Length,
                        ExpectedParameterLength);
                    continue;
                }

                if (item.EncryptedPublicKey.Length != ExpectedParameterLength)
                {
                    Log.Warning("Invalid queue item, EncryptedPublicKey length ({Actual} != {Expected})",
                        item.EncryptedPublicKey.Length,
                        ExpectedParameterLength);
                    continue;
                }

                // Write count.
                BinaryPrimitives.WriteUInt32LittleEndian(buffer, counter++);
                await output.WriteAsync(buffer.AsMemory(0, sizeof(uint)));
                
                // Write EncryptedGenerator.
                HexUtils.HexToSpan(item.EncryptedGenerator, buffer);
                await output.WriteAsync(buffer.AsMemory(0, item.EncryptedGenerator.Length / 2));
                
                // Write EncryptedPrime.
                HexUtils.HexToSpan(item.EncryptedPrime, buffer);
                await output.WriteAsync(buffer.AsMemory(0, item.EncryptedPrime.Length / 2));
                
                // Write EncryptedPublicKey.
                HexUtils.HexToSpan(item.EncryptedPublicKey, buffer);
                await output.WriteAsync(buffer.AsMemory(0, item.EncryptedPublicKey.Length / 2));
                
                Log.Information("Progress {Count,-8} / {Total,-8}", counter, Constants.DumpTotal);

                // If we wrote enough, cancel the dump tasks.
                // We don't really care if we write more than we need.
                if (counter >= Constants.DumpTotal && !_cancellationDump.IsCancellationRequested)
                {
                    _cancellationDump.Cancel();
                }
            }
        }
        catch (OperationCanceledException)
        {
            if (!_cancellationDump.IsCancellationRequested)
            {
                // Improper cancellation.
                Log.Information("SaveAsync cancelled");
            }
        }
    }

    public async ValueTask DisposeAsync()
    {
        _cancellationWrite.Cancel();
        _cancellationDump.Cancel();

        if (_saveTask != null)
        {
            await _saveTask;
        }

        if (_dumpTasks != null)
        {
            await Task.WhenAll(_dumpTasks);
        }
        
        _cancellationWrite.Dispose();
        _cancellationDump.Dispose();
    }
}