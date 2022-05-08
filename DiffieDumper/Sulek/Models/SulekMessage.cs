using System.Text.Json.Serialization;

namespace DiffieDumper.Sulek.Models;

public class SulekMessage
{
    [JsonPropertyName("id")]
    public short Id { get; set; }

    [JsonPropertyName("name")] 
    public string Name { get; set; } = null!;
        
    [JsonPropertyName("asNamespace")]
    public string AsNamespace { get; set; } = null!;
        
    [JsonPropertyName("asClass")]
    public string AsClass { get; set; } = null!;
        
    [JsonPropertyName("confident")]
    public bool Confident { get; set; }
}