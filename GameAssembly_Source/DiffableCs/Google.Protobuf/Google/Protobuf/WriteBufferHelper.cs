namespace Google.Protobuf;

internal struct WriteBufferHelper
{
	private IBufferWriter<Byte> bufferWriter; //Field offset: 0x0
	private CodedOutputStream codedOutputStream; //Field offset: 0x8

	public CodedOutputStream CodedOutputStream
	{
		 get { } //Length: 5
	}

	public CodedOutputStream get_CodedOutputStream() { }

	public static void RefreshBuffer(ref Span<Byte>& buffer, ref WriterInternalState state) { }

}

