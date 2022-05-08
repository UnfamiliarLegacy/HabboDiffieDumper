using System.Buffers;
using System.Runtime.CompilerServices;
using System.Text;

namespace DiffieDumper.Net.Serialization;

/// <summary>
///     Habbo packet reader.
///     We don't really care about the read results because we're 100% sure about the packet contents.
/// </summary>
public ref struct PacketReader
{
    private SequenceReader<byte> _reader;
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public PacketReader(Message message)
    {
        _reader = new SequenceReader<byte>(message.Payload);
        _reader.Advance(2); // Skip packet id
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool ReadBool()
    {
        return ReadByte() == 1;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public byte ReadByte()
    {
        _ = _reader.TryRead(out var result);
        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public short ReadShort()
    {
        _ = _reader.TryReadBigEndian(out short result);
        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int ReadInt()
    {
        _ = _reader.TryReadBigEndian(out int result);
        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string ReadString()
    {
        var byteCount = ReadShort();
        if (byteCount < 0)
        {
            throw new ArgumentException("Invalid string length");
        }

        if (byteCount == 0)
        {
            return string.Empty;
        }

        var result = PacketWriter.Utf8.GetString(_reader.Sequence.Slice(_reader.Position, byteCount));
        
        _reader.Advance(byteCount);
        
        return result;
    }
}