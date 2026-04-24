namespace Google.Protobuf;

internal static class WritingPrimitives
{
	internal static readonly Encoding Utf8Encoding; //Field offset: 0x6A460

	private static WritingPrimitives() { }

	public static void WriteBool(ref Span<Byte>& buffer, ref WriterInternalState state, bool value) { }

	public static void WriteBytes(ref Span<Byte>& buffer, ref WriterInternalState state, ByteString value) { }

	public static void WriteDouble(ref Span<Byte>& buffer, ref WriterInternalState state, double value) { }

	public static void WriteEnum(ref Span<Byte>& buffer, ref WriterInternalState state, int value) { }

	public static void WriteFixed32(ref Span<Byte>& buffer, ref WriterInternalState state, uint value) { }

	public static void WriteFixed64(ref Span<Byte>& buffer, ref WriterInternalState state, ulong value) { }

	public static void WriteInt32(ref Span<Byte>& buffer, ref WriterInternalState state, int value) { }

	public static void WriteInt64(ref Span<Byte>& buffer, ref WriterInternalState state, long value) { }

	public static void WriteLength(ref Span<Byte>& buffer, ref WriterInternalState state, int length) { }

	private static void WriteRawByte(ref Span<Byte>& buffer, ref WriterInternalState state, byte value) { }

	public static void WriteRawBytes(ref Span<Byte>& buffer, ref WriterInternalState state, ReadOnlySpan<Byte> value) { }

	public static void WriteRawBytes(ref Span<Byte>& buffer, ref WriterInternalState state, Byte[] value) { }

	public static void WriteRawLittleEndian32(ref Span<Byte>& buffer, ref WriterInternalState state, uint value) { }

	private static void WriteRawLittleEndian32SlowPath(ref Span<Byte>& buffer, ref WriterInternalState state, uint value) { }

	public static void WriteRawLittleEndian64(ref Span<Byte>& buffer, ref WriterInternalState state, ulong value) { }

	public static void WriteRawLittleEndian64SlowPath(ref Span<Byte>& buffer, ref WriterInternalState state, ulong value) { }

	public static void WriteRawTag(ref Span<Byte>& buffer, ref WriterInternalState state, byte b1) { }

	public static void WriteRawTag(ref Span<Byte>& buffer, ref WriterInternalState state, byte b1, byte b2) { }

	private static void WriteRawTagSlowPath(ref Span<Byte>& buffer, ref WriterInternalState state, byte b1, byte b2) { }

	public static void WriteRawVarint32(ref Span<Byte>& buffer, ref WriterInternalState state, uint value) { }

	public static void WriteRawVarint64(ref Span<Byte>& buffer, ref WriterInternalState state, ulong value) { }

	public static void WriteString(ref Span<Byte>& buffer, ref WriterInternalState state, string value) { }

	private static int WriteStringToBuffer(Span<Byte> buffer, ref WriterInternalState state, string value) { }

	public static void WriteTag(ref Span<Byte>& buffer, ref WriterInternalState state, int fieldNumber, WireType type) { }

	public static void WriteTag(ref Span<Byte>& buffer, ref WriterInternalState state, uint tag) { }

	public static void WriteUInt64(ref Span<Byte>& buffer, ref WriterInternalState state, ulong value) { }

}

