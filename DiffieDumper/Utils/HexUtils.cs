namespace DiffieDumper.Utils;

/// <summary>
///     https://gist.github.com/crozone/06c4aa41e13be89def1352ba0d378b0f
/// </summary>
public static class HexUtils
{
    public static Span<byte> HexToSpan(ReadOnlySpan<char> inputChars, Span<byte> decodedBytesBuffer)
    {
        if (inputChars.Length % 2 != 0)
        {
            throw new InvalidOperationException($"{nameof(inputChars)} length must be even");
        }

        int bufferLength = inputChars.Length / 2;
        if (decodedBytesBuffer.Length < bufferLength)
        {
            throw new InvalidOperationException($"{nameof(decodedBytesBuffer)} must be at least half the length of {nameof(inputChars)}");
        }

        for (int bx = 0, sx = 0; bx < bufferLength; ++bx, ++sx)
        {
            // Convert first half of byte
            char c = inputChars[sx];
            decodedBytesBuffer[bx] = (byte)((c > '9' ? (c > 'Z' ? (c - 'a' + 10) : (c - 'A' + 10)) : (c - '0')) << 4);

            // Convert second half of byte
            c = inputChars[++sx];
            decodedBytesBuffer[bx] |= (byte)(c > '9' ? (c > 'Z' ? (c - 'a' + 10) : (c - 'A' + 10)) : (c - '0'));
        }

        return decodedBytesBuffer.Slice(0, bufferLength);
    }
}