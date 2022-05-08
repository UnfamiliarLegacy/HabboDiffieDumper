using System.Text.Json;
using DiffieDumper.Net.Packets;
using DiffieDumper.Sulek.Models;
using Serilog;

namespace DiffieDumper.Sulek;

public class LibraryManager
{
    private static readonly ILogger Logger = Log.ForContext<LibraryManager>();
        
    private readonly Dictionary<PacketC2S, short> _packetC2S;
    private readonly Dictionary<short, PacketC2S> _packetC2SLookup;
        
    private readonly Dictionary<PacketS2C, short> _packetS2C;
    private readonly Dictionary<short, PacketS2C> _packetS2CLookup;

    public LibraryManager()
    {
        _packetC2S = new Dictionary<PacketC2S, short>();
        _packetC2SLookup = new Dictionary<short, PacketC2S>();
            
        _packetS2C = new Dictionary<PacketS2C, short>();
        _packetS2CLookup = new Dictionary<short, PacketS2C>();
    }
        
    public async Task<bool> InitializeAsync(string release)
    {
        using (var client = new HttpClient())
        {
            var req = new HttpRequestMessage(HttpMethod.Get, $"https://api.sulek.dev/releases/{release}/messages");
            var res = await client.SendAsync(req);
            
            if (!res.IsSuccessStatusCode)
            {
                Logger.Error("Failed to load release {Release}, response was {Response}", release, res.StatusCode);
                return false;
            }

            await using (var stream = await res.Content.ReadAsStreamAsync())
            {
                var dataParsed = JsonSerializer.Deserialize<SulekResponse>(stream);
                if (dataParsed == null)
                {
                    Logger.Error("Failed to load release {Release}, dataParsed was null", release);
                    return false;
                }
                    
                LoadPackets(_packetC2S, _packetC2SLookup, dataParsed.Messages.Outgoing);
                LoadPackets(_packetS2C, _packetS2CLookup, dataParsed.Messages.Incoming);
            }
        }

        return true;
    }

    public short? FindMessageIdC2S(PacketC2S packet)
    {
        return FindMessageId(_packetC2S, packet);
    }

    public short? FindMessageIdS2C(PacketS2C packet)
    {
        return FindMessageId(_packetS2C, packet);
    }

    public PacketC2S? FindMessageTypeC2S(short messageId)
    {
        return FindMessageType(_packetC2SLookup, messageId);
    }

    public PacketS2C? FindMessageTypeS2C(short messageId)
    {
        return FindMessageType(_packetS2CLookup, messageId);
    }

    private static short? FindMessageId<T>(IDictionary<T, short> packets, T packet) where T : struct, Enum
    {
        if (packets.TryGetValue(packet, out var messageId))
        {
            return messageId;
        }

        return null;
    }

    private static T? FindMessageType<T>(IDictionary<short, T> packets, short messageId) where T : struct, Enum
    {
        if (packets.TryGetValue(messageId, out var messageType))
        {
            return messageType;
        }

        return null;
    }

    private static void LoadPackets<T>(
        IDictionary<T, short> destination, 
        IDictionary<short, T> destinationLookup, 
        IEnumerable<SulekMessage> messages) where T : struct, Enum
    {
        foreach (var message in messages)
        {
            // TODO: Remove?
            if (!Enum.TryParse(typeof(T), message.Name, out var packet))
            {
                Logger.Debug("Failed to find {Release} {Type} {Name}", "RELEASE", typeof(T).Name, message.Name);
                continue;
            }
                
            destination.Add((T) packet!, message.Id);
            destinationLookup.Add(message.Id, (T) packet);
        }
    }
}