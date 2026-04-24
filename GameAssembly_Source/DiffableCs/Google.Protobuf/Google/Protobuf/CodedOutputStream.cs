namespace Google.Protobuf;

public sealed class CodedOutputStream
{
	internal sealed class OutOfSpaceException : IOException
	{

		internal OutOfSpaceException() { }

	}

	public static readonly int DefaultBufferSize; //Field offset: 0x0
	private readonly Byte[] buffer; //Field offset: 0x10
	private WriterInternalState state; //Field offset: 0x18
	private readonly Stream output; //Field offset: 0x30

	internal Byte[] InternalBuffer
	{
		internal get { } //Length: 5
	}

	internal Stream InternalOutputStream
	{
		internal get { } //Length: 5
	}

	internal WriterInternalState InternalState
	{
		internal get { } //Length: 5
	}

	private static CodedOutputStream() { }

	public static int ComputeBytesSize(ByteString value) { }

	public static int ComputeEnumSize(int value) { }

	public static int ComputeFixed32Size(uint value) { }

	public static int ComputeFixed64Size(ulong value) { }

	public static int ComputeInt32Size(int value) { }

	public static int ComputeInt64Size(long value) { }

	public static int ComputeLengthSize(int length) { }

	public static int ComputeMessageSize(IMessage value) { }

	public static int ComputeRawVarint32Size(uint value) { }

	public static int ComputeRawVarint64Size(ulong value) { }

	public static int ComputeStringSize(string value) { }

	public static int ComputeTagSize(int fieldNumber) { }

	public static int ComputeUInt64Size(ulong value) { }

	internal Byte[] get_InternalBuffer() { }

	internal Stream get_InternalOutputStream() { }

	internal WriterInternalState get_InternalState() { }

	public void WriteRawMessage(IMessage value) { }

}

