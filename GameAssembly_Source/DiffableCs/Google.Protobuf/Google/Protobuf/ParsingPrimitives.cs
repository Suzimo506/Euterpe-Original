namespace Google.Protobuf;

internal static class ParsingPrimitives
{

	public static bool IsDataAvailable(ref ParserInternalState state, int size) { }

	private static bool IsDataAvailableInSource(ref ParserInternalState state, int size) { }

	public static bool MaybeConsumeTag(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state, uint tag) { }

	public static double ParseDouble(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state) { }

	public static int ParseLength(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state) { }

	public static uint ParseRawLittleEndian32(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state) { }

	private static uint ParseRawLittleEndian32SlowPath(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state) { }

	public static ulong ParseRawLittleEndian64(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state) { }

	private static ulong ParseRawLittleEndian64SlowPath(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state) { }

	public static uint ParseRawVarint32(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state) { }

	private static uint ParseRawVarint32SlowPath(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state) { }

	public static ulong ParseRawVarint64(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state) { }

	private static ulong ParseRawVarint64SlowPath(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state) { }

	public static uint ParseTag(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state) { }

	public static uint PeekTag(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state) { }

	public static ByteString ReadBytes(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state) { }

	private static byte ReadRawByte(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state) { }

	public static Byte[] ReadRawBytes(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state, int size) { }

	private static void ReadRawBytesIntoSpan(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state, int length, Span<Byte> byteSpan) { }

	private static Byte[] ReadRawBytesSlow(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state, int size) { }

	public static string ReadRawString(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state, int length) { }

	public static string ReadString(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state) { }

	private static string ReadStringSlow(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state, int length) { }

	public static void SkipRawBytes(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state, int size) { }

	private static void ValidateCurrentLimit(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state, int size) { }

}

