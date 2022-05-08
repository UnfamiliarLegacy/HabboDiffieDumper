using System.Diagnostics;
using DiffieDumper.Saver;
using DiffieDumper.Sulek;
using Serilog;
using Serilog.Events;

namespace DiffieDumper;

internal static class Program
{
    public static async Task Main()
    {
        Log.Logger = new LoggerConfiguration()
#if DEBUG
            .MinimumLevel.Verbose()
#else
            .MinimumLevel.Information()
#endif
            .MinimumLevel.Override("Bedrock", LogEventLevel.Warning)
            .WriteTo.Console()
            .CreateLogger();

        var timer = Stopwatch.StartNew();

        // Sulek library manager.
        var library = new LibraryManager();
        
        if (!await library.InitializeAsync(Constants.HabboRelease))
        {
            Log.Error("Failed to initialize LibraryManager");
            return;
        }
        
        // Create the saver.
        await using var saver = new SaverManager(library);
        
        // Run.
        await saver.RunAsync();

        Log.Information("Finished in {Time}", timer.Elapsed.ToString(@"hh\:mm\:ss"));
    }
}