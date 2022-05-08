using System.Buffers;
using Bedrock.Framework.Protocols;
using DiffieDumper.Net.Packets;
using DiffieDumper.Net.Serialization;
using DiffieDumper.Sulek;

namespace DiffieDumper.Net.Protocols;

public class HabboWriter : IAsyncDisposable
{
    /// <summary>
    ///     Taken from a handshake using G-Earth.
    /// </summary>
    private const string HardcodedPublicKey = "9204568c196bcd4b2930fdf37090580895b6d08acc94986133d0cf73dbb030f7" + 
                                              "8921b2b7c0754ba20bc39528eda390c9d850e933f03c7b2b333559ca71a53aaf" + 
                                              "fd660e37aca22f3a14a638c290793fc55ad071ccb9835ce982d85425a76384d6" + 
                                              "55c5eae44f33a0bdfe49058d9d3ecd6c429db6508ace83f224158d07a2a82e7a" + 
                                              "12574066982fb08412d60227df0ed10058c19a985261e3ea4051328e648959c3" + 
                                              "686c1ebd5b2f39762c84d94272a0b07c8f4b5ce45e3f222204ef2b45a1bf558e" + 
                                              "8607ca443707c1a65a2c5fe08e3b264c7b1530cfce8aed215cc5feb0dbef1fb0" + 
                                              "e2f977b3b5dede2ee29e007108e8a5b41513b6de3c36536d9764e8601d272f03";

    private readonly ProtocolWriter _writer;
    private readonly LengthPrefixedProtocol _protocol;
    private readonly LibraryManager _library;
    private readonly IMemoryOwner<byte> _buffer;

    public HabboWriter(ProtocolWriter writer, LengthPrefixedProtocol protocol, LibraryManager library)
    {
        _writer = writer;
        _protocol = protocol;
        _library = library;
        _buffer = MemoryPool<byte>.Shared.Rent(4096);
    }
    
    public ValueTask WriteClientHello()
    {
        var packetId = _library.FindMessageIdC2S(PacketC2S.ClientHelloMessageComposer)!.Value;
        var packet = _buffer.Memory.Span;
        
        PacketWriter.WriteShort(ref packet, packetId);
        PacketWriter.WriteString(ref packet, Constants.HabboRelease);
        PacketWriter.WriteString(ref packet, Constants.HabboProtocol);
        PacketWriter.WriteInt(ref packet, 1);
        PacketWriter.WriteInt(ref packet, 0);

        return WriteAsync(packet);
    }
    
    public ValueTask WriteInitDiffieHandshake()
    {
        var packetId = _library.FindMessageIdC2S(PacketC2S.InitDiffieHandshakeMessageComposer)!.Value;
        var packet = _buffer.Memory.Span;
        
        PacketWriter.WriteShort(ref packet, packetId);
        
        return WriteAsync(packet);
    }
    
    public ValueTask WriteCompleteDiffieHandshake()
    {
        var packetId = _library.FindMessageIdC2S(PacketC2S.CompleteDiffieHandshakeMessageComposer)!.Value;
        var packet = _buffer.Memory.Span;
        
        PacketWriter.WriteShort(ref packet, packetId);
        PacketWriter.WriteString(ref packet, HardcodedPublicKey);
        
        return WriteAsync(packet);
    }

    private ValueTask WriteAsync(Span<byte> packet)
    {
        var bufferLength = _buffer.Memory.Length - packet.Length;
        var buffer = new ReadOnlySequence<byte>(_buffer.Memory.Slice(0, bufferLength));
        
        return _writer.WriteAsync(_protocol, new Message(buffer));
    }

    public async ValueTask DisposeAsync()
    {
        await _writer.DisposeAsync();
        
        _buffer.Dispose();
    }
}