using DiffieDumper.Net.Serialization;

namespace DiffieDumper.Net.Protocols.Models;

public readonly struct CompleteDiffieHandshake
{
    public CompleteDiffieHandshake(PacketReader reader)
    {
        EncryptedPublicKey = reader.ReadString();
        ServerClientEncryption = reader.ReadBool();
    }
    
    public string EncryptedPublicKey { get; }
    public bool ServerClientEncryption { get; }
}