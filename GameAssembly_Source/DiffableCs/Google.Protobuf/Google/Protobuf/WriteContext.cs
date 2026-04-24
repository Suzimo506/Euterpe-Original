namespace Google.Protobuf;

[IsByRefLike]
[Obsolete]
public struct WriteContext
{
	internal Span<Byte> buffer; //Field offset: 0x0
	internal WriterInternalState state; //Field offset: 0x18

	internal void CopyStateTo(CodedOutputStream output) { }

	internal static void Initialize(ref Span<Byte>& buffer, ref WriterInternalState state, out WriteContext ctx) { }

	internal void LoadStateFrom(CodedOutputStream output) { }

	public void WriteBool(bool value) { }

	public void WriteBytes(ByteString value) { }

	public void WriteDouble(double value) { }

	public void WriteEnum(int value) { }

	public void WriteFixed32(uint value) { }

	public void WriteFixed64(ulong value) { }

	public void WriteInt32(int value) { }

	public void WriteInt64(long value) { }

	public void WriteLength(int length) { }

	public void WriteMessage(IMessage value) { }

	public void WriteRawTag(byte b1) { }

	public void WriteRawTag(byte b1, byte b2) { }

	public void WriteString(string value) { }

	public void WriteTag(int fieldNumber, WireType type) { }

	public void WriteTag(uint tag) { }

	public void WriteUInt64(ulong value) { }

}

