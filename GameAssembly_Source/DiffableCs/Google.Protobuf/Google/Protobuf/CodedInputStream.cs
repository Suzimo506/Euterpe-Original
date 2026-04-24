namespace Google.Protobuf;

public sealed class CodedInputStream : IDisposable
{
	private readonly bool leaveOpen; //Field offset: 0x10
	private readonly Byte[] buffer; //Field offset: 0x18
	private readonly Stream input; //Field offset: 0x20
	private ParserInternalState state; //Field offset: 0x28

	internal bool DiscardUnknownFields
	{
		internal set { } //Length: 7
	}

	internal ExtensionRegistry ExtensionRegistry
	{
		internal set { } //Length: 15
	}

	internal Byte[] InternalBuffer
	{
		internal get { } //Length: 5
	}

	internal Stream InternalInputStream
	{
		internal get { } //Length: 5
	}

	internal ParserInternalState InternalState
	{
		internal get { } //Length: 5
	}

	public CodedInputStream(Byte[] buffer) { }

	internal CodedInputStream(Stream input, Byte[] buffer, int bufferPos, int bufferSize, bool leaveOpen) { }

	internal void CheckReadEndOfStreamTag() { }

	public override void Dispose() { }

	internal Byte[] get_InternalBuffer() { }

	internal Stream get_InternalInputStream() { }

	internal ParserInternalState get_InternalState() { }

	public void ReadRawMessage(IMessage message) { }

	internal void set_DiscardUnknownFields(bool value) { }

	internal void set_ExtensionRegistry(ExtensionRegistry value) { }

}

