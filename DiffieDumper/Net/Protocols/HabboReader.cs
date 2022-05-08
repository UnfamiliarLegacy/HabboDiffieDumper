using System.Buffers;
using Bedrock.Framework.Protocols;
using DiffieDumper.Net.Packets;
using DiffieDumper.Net.Protocols.Models;
using DiffieDumper.Net.Serialization;
using DiffieDumper.Sulek;

namespace DiffieDumper.Net.Protocols;

public class HabboReader : IAsyncDisposable
{
    private readonly ProtocolReader _reader;
    private readonly LengthPrefixedProtocol _protocol;
    private readonly LibraryManager _library;

    public HabboReader(ProtocolReader reader, LengthPrefixedProtocol protocol, LibraryManager library)
    {
        _reader = reader;
        _protocol = protocol;
        _library = library;
    }

    public async Task<ProtocolReadResult<Message>> ReadAsync()
    {
        return await _reader.ReadAsync(_protocol);
    }

    public void Advance()
    {
        _reader.Advance();
    }

    public PacketS2C? ReadPacketType(Message message)
    {
        var reader = new SequenceReader<byte>(message.Payload);
        if (reader.TryReadBigEndian(out short packetId))
        {
            return _library.FindMessageTypeS2C(packetId);
        }

        return null;
    }

    public InitDiffieHandshake ReadInitDiffieHandshake(Message message)
    {
        return new InitDiffieHandshake(new PacketReader(message));
    }

    public CompleteDiffieHandshake ReadCompleteDiffieHandshake(Message message)
    {
        return new CompleteDiffieHandshake(new PacketReader(message));
    }

    public async ValueTask DisposeAsync()
    {
        await _reader.DisposeAsync();
    }
}