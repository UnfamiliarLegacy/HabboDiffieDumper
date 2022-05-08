using System.Text.Json.Serialization;

namespace DiffieDumper.Sulek.Models;

public class SulekResponse
{
    [JsonPropertyName("lastCheckedAt")]
    public DateTimeOffset? LastCheckedAt { get; set; } = null!;
        
    [JsonPropertyName("messages")]
    public SulekMessages Messages { get; set; } = null!;
}