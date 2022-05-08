namespace DiffieDumper;

public static class Constants
{
    /**
     * Habbo specific.
     */
    
    public const string HabboRelease = "WIN63-202201241601-944343569";
    public const string HabboProtocol = "FLASH3";
    
    public static readonly List<string> HabboServers = new List<string>
    {
        "game-us.habbo.com",
        "game-br.habbo.com",
        "game-fi.habbo.com",
        "game-fr.habbo.com",
        "game-de.habbo.com",
        "game-nl.habbo.com",
        "game-es.habbo.com",
        "game-it.habbo.com",
        "game-tr.habbo.com"
    };
    
    public const int HabboPort = 30000;
    
    /**
     * Saver.
     */
    
    /// The amount of handshakes to dump.
    public const int DumpTotal = 1_000;
    
    /// The amount of concurrent handshakes per server.
    public const int DumpConcurrency = 100;
    
    /// The size of the write queue.
    public const int WriteQueueCapacity = 1_000;
}