using System.Text.Json.Serialization;

namespace DiffieDumper.Sulek.Models;

public class SulekMessages
{
    [JsonPropertyName("outgoing")]
    public List<SulekMessage> Outgoing { get; set; } = null!;
        
    [JsonPropertyName("incoming")]
    public List<SulekMessage> Incoming { get; set; } = null!;
}