namespace Google.Protobuf;

[IsByRefLike]
[Obsolete]
public struct ParseContext
{
	internal ReadOnlySpan<Byte> buffer; //Field offset: 0x0
	internal ParserInternalState state; //Field offset: 0x18

	internal bool DiscardUnknownFields
	{
		internal get { } //Length: 8
	}

	internal ExtensionRegistry ExtensionRegistry
	{
		internal get { } //Length: 8
	}

	internal uint LastTag
	{
		internal get { } //Length: 7
	}

	internal void CopyStateTo(CodedInputStream input) { }

	internal bool get_DiscardUnknownFields() { }

	internal ExtensionRegistry get_ExtensionRegistry() { }

	internal uint get_LastTag() { }

	internal static void Initialize(CodedInputStream input, out ParseContext ctx) { }

	internal static void Initialize(ReadOnlySequence<Byte> input, out ParseContext ctx) { }

	internal static void Initialize(ReadOnlySequence<Byte> input, int recursionLimit, out ParseContext ctx) { }

	internal void LoadStateFrom(CodedInputStream input) { }

	public bool ReadBool() { }

	public ByteString ReadBytes() { }

	public double ReadDouble() { }

	public int ReadEnum() { }

	public uint ReadFixed32() { }

	public ulong ReadFixed64() { }

	public int ReadInt32() { }

	public long ReadInt64() { }

	public int ReadLength() { }

	public void ReadMessage(IMessage message) { }

	public string ReadString() { }

	public uint ReadTag() { }

	public ulong ReadUInt64() { }

}

