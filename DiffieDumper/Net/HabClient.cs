using System.Buffers;
using System.Net;
using Bedrock.Framework;
using Bedrock.Framework.Protocols;
using DiffieDumper.Net.Packets;
using DiffieDumper.Net.Protocols;
using DiffieDumper.Net.Serialization;
using DiffieDumper.Saver;
using DiffieDumper.Sulek;
using Microsoft.Extensions.Logging;
using Serilog;

namespace DiffieDumper.Net;

public class HabClient
{
    private readonly LibraryManager _library;
    private readonly SaverQueue _queue;
    private readonly Client _client;
    
    public HabClient(LibraryManager library, SaverQueue queue, ILoggerFactory loggerFactory)
    {
        _library = library;
        _queue = queue;
        _client = new ClientBuilder()
            .UseSockets()
            .UseConnectionLogging(loggerFactory: loggerFactory)
            .Build();
    }

    public async ValueTask<bool> DumpAsync(string serverIp, CancellationToken token)
    {
        // Result.
        var queueEntry = new SaverQueueEntry();
        var queueReady = false;
        
        await using (var connection = await _client.ConnectAsync(new DnsEndPoint(serverIp, Constants.HabboPort), token))
        {
            Log.Debug("Connected to {RemoteEndPoint}", connection.RemoteEndPoint!.ToString());
            
            // Initialize buffer for this connection.
            using var buffer = MemoryPool<byte>.Shared.Rent(2048);
            
            // Initialize I/O.
            var protocol = new LengthPrefixedProtocol();
            await using var reader = new HabboReader(connection.CreateReader(), protocol, _library);
            await using var writer = new HabboWriter(connection.CreateWriter(), protocol, _library);
            
            // Send initial packets.
            await writer.WriteClientHello();
            await writer.WriteInitDiffieHandshake();
            
            // Retrieve init / complete parameters.
            while (true)
            {
                var result = await reader.ReadAsync();
                if (result.IsCompleted)
                {
                    Log.Warning("Connection forcibly closed");
                    return false;
                }
                
                try
                {
                    var packetType = reader.ReadPacketType(result.Message);
                    if (packetType != null)
                    {
                        if (packetType == PacketS2C.InitDiffieHandshakeEvent)
                        {
                            await writer.WriteCompleteDiffieHandshake();

                            var init = reader.ReadInitDiffieHandshake(result.Message);

                            queueEntry.EncryptedGenerator = init.EncryptedGenerator;
                            queueEntry.EncryptedPrime = init.EncryptedPrime;
                            continue;
                        } 
                        else if (packetType == PacketS2C.CompleteDiffieHandshakeEvent)
                        {
                            var complete = reader.ReadCompleteDiffieHandshake(result.Message);
                        
                            queueEntry.EncryptedPublicKey = complete.EncryptedPublicKey;
                            queueReady = true;
                            break;
                        } 
                        else if (packetType == PacketS2C.DisconnectReasonEvent || 
                                 packetType == PacketS2C.ErrorReportEvent)
                        {
                            break;
                        } 
                        else if (packetType == PacketS2C.PingMessageEvent)
                        {
                            continue;
                        }
                    
                        Log.Warning("> Unhandled packet {PacketType}", packetType);
                    }
                }
                finally
                {
                    reader.Advance();
                }
            }
            
            // Close.
            // Note: Not sure why, but if we only have the "await using" above it doesn't terminate the socket properly
            await connection.DisposeAsync();
        }
        
        // Save.
        if (queueReady)
        {
            await _queue.EnqueueAsync(queueEntry);
        }

        return queueReady;
    }
}