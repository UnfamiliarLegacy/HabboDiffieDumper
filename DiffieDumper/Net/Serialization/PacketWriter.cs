using System.Buffers.Binary;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace DiffieDumper.Net.Serialization;

/// <summary>
///     Modified version of https://gist.github.com/BastianBlokland/f97f832dafa4461f091a6d2851c3e46d
/// </summary>
public static unsafe class PacketWriter
{
    public static readonly Encoding Utf8 = Encoding.UTF8;

    /// <summary>
    /// Write a boolean.
    /// </summary>
    /// <remarks>
    /// Will consume 1 byte.
    /// </remarks>
    /// <param name="span">Span to write to.</param>
    /// <param name="val">Value to write.</param>
    public static void WriteBool(ref Span<byte> span, bool val)
    {
        MemoryMarshal.Write(span, ref val);

        // 'Advance' the span.
        span = span.Slice(sizeof(bool));
    }

    /// <summary>
    /// Write a unsigned 8 bit integer.
    /// </summary>
    /// <remarks>
    /// Will consume 1 byte.
    /// </remarks>
    /// <param name="span">Span to write to.</param>
    /// <param name="val">Value to write.</param>
    public static void WriteByte(ref Span<byte> span, byte val)
    {
        MemoryMarshal.Write(span, ref val);

        // 'Advance' the span.
        span = span.Slice(sizeof(byte));
    }

    /// <summary>
    /// Write a signed 8 bit integer.
    /// </summary>
    /// <remarks>
    /// Will consume 1 byte.
    /// </remarks>
    /// <param name="span">Span to write to.</param>
    /// <param name="val">Value to write.</param>
    public static void WriteSByte(ref Span<byte> span, sbyte val)
    {
        MemoryMarshal.Write(span, ref val);

        // 'Advance' the span.
        span = span.Slice(sizeof(sbyte));
    }

    /// <summary>
    /// Write a 16 bit signed integer.
    /// </summary>
    /// <remarks>
    /// Will consume 2 bytes.
    /// </remarks>
    /// <param name="span">Span to write to.</param>
    /// <param name="val">Value to write.</param>
    public static void WriteShort(ref Span<byte> span, short val)
    {
        BinaryPrimitives.WriteInt16BigEndian(span, val);

        // 'Advance' the span.
        span = span.Slice(sizeof(short));
    }

    /// <summary>
    /// Write a 16 bit unsigned integer.
    /// </summary>
    /// <remarks>
    /// Will consume 2 bytes.
    /// </remarks>
    /// <param name="span">Span to write to.</param>
    /// <param name="val">Value to write.</param>
    public static void WriteUShort(ref Span<byte> span, ushort val)
    {
        BinaryPrimitives.WriteUInt16BigEndian(span, val);

        // 'Advance' the span.
        span = span.Slice(sizeof(ushort));
    }

    /// <summary>
    /// Write a 32 bit signed integer.
    /// </summary>
    /// <remarks>
    /// Will consume 4 bytes.
    /// </remarks>
    /// <param name="span">Span to write to.</param>
    /// <param name="val">Value to write.</param>
    public static void WriteInt(ref Span<byte> span, int val)
    {
        BinaryPrimitives.WriteInt32BigEndian(span, val);

        // 'Advance' the span.
        span = span.Slice(sizeof(int));
    }

    /// <summary>
    /// Write a 32 bit unsigned integer.
    /// </summary>
    /// <remarks>
    /// Will consume 4 bytes.
    /// </remarks>
    /// <param name="span">Span to write to.</param>
    /// <param name="val">Value to write.</param>
    public static void WriteUInt(ref Span<byte> span, uint val)
    {
        BinaryPrimitives.WriteUInt32BigEndian(span, val);

        // 'Advance' the span.
        span = span.Slice(sizeof(uint));
    }

    /// <summary>
    /// Write a 64 bit signed integer.
    /// </summary>
    /// <remarks>
    /// Will consume 8 bytes.
    /// </remarks>
    /// <param name="span">Span to write to.</param>
    /// <param name="val">Value to write.</param>
    public static void WriteLong(ref Span<byte> span, long val)
    {
        BinaryPrimitives.WriteInt64BigEndian(span, val);

        // 'Advance' the span.
        span = span.Slice(sizeof(long));
    }

    /// <summary>
    /// Write a 64 bit unsigned integer.
    /// </summary>
    /// <remarks>
    /// Will consume 8 bytes.
    /// </remarks>
    /// <param name="span">Span to write to.</param>
    /// <param name="val">Value to write.</param>
    public static void WriteULong(ref Span<byte> span, ulong val)
    {
        BinaryPrimitives.WriteUInt64BigEndian(span, val);

        // 'Advance' the span.
        span = span.Slice(sizeof(ulong));
    }

    /// <summary>
    /// Write a 64 bit floating-point number.
    /// </summary>
    /// <remarks>
    /// Will consume 8 bytes.
    /// </remarks>
    /// <param name="span">Span to write to.</param>
    /// <param name="val">Value to write.</param>
    public static void WriteDouble(ref Span<byte> span, double val)
    {
        MemoryMarshal.Write(span, ref val);

        // 'Advance' the span.
        span = span.Slice(sizeof(double));
    }

    /// <summary>
    /// Write a string as utf8.
    /// </summary>
    /// <remarks>
    /// Prefixes the data with a 'packed unsigned integer' telling how many bytes will follow.
    /// Format will match that of a <see cref="System.IO.BinaryWriter"/> that is using utf8 encoding.
    /// </remarks>
    /// <param name="span">Span to write to.</param>
    /// <param name="val">Value to write.</param>
    public static void WriteString(ref Span<byte> span, string val)
    {
        fixed (char* charPointer = val)
        {
            WriteString(ref span, charPointer, val.Length);
        }
    }

    /// <summary>
    /// Write a string as utf8.
    /// </summary>
    /// <remarks>
    /// Prefixes the data with a 'packed unsigned integer' telling how many bytes will follow.
    /// Format will match that of a <see cref="System.IO.BinaryWriter"/> that is using utf8 encoding.
    /// </remarks>
    /// <param name="span">Span to write to.</param>
    /// <param name="val">Value to write.</param>
    public static void WriteString(ref Span<byte> span, ReadOnlySpan<char> val)
    {
        fixed (char* charPointer = val)
        {
            WriteString(ref span, charPointer, val.Length);
        }
    }

    /// <summary>
    /// Write a string as utf8.
    /// Make sure the data behind the pointer is pinned before calling this.
    /// </summary>
    /// <remarks>
    /// Prefixes the data with a 'packed unsigned integer' telling how many bytes will follow.
    /// Format will match that of a <see cref="System.IO.BinaryWriter"/> that is using utf8 encoding.
    /// </remarks>
    /// <param name="span">Span to write to.</param>
    /// <param name="charPointer">Pointer to the first character.</param>
    /// <param name="charPointer">How many characters are in the string.</param>
    public static void WriteString(ref Span<byte> span, char* charPointer, int charCount)
    {
        // Write amount of bytes will follow.
        var byteCount = Utf8.GetByteCount(charPointer, charCount);
        WriteShort(ref span, (short)byteCount);

        fixed (byte* spanPointer = span)
        {
            // Write chars as utf8.
            var writtenBytes = Utf8.GetBytes(charPointer, charCount, spanPointer, span.Length);
            Debug.Assert(byteCount == writtenBytes, "Written bytes did not match encodings expected size");
        }

        // 'Advance' the span.
        span = span.Slice(byteCount);
    }
}