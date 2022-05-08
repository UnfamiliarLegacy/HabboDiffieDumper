namespace DiffieDumper.Saver;

public class SaverQueueEntry
{
    public string? EncryptedGenerator { get; set; }
    public string? EncryptedPrime { get; set; }
    public string? EncryptedPublicKey { get; set; }
}