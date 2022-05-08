using DiffieDumper.Net.Serialization;

namespace DiffieDumper.Net.Protocols.Models;

public readonly struct InitDiffieHandshake
{
    public InitDiffieHandshake(PacketReader reader)
    {
        EncryptedPrime = reader.ReadString();
        EncryptedGenerator = reader.ReadString();
    }

    public string EncryptedPrime { get; }
    public string EncryptedGenerator { get; }
}