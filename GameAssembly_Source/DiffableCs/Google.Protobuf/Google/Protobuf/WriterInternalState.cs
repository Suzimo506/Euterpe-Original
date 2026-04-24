namespace Google.Protobuf;

internal struct WriterInternalState
{
	internal int limit; //Field offset: 0x0
	internal int position; //Field offset: 0x4
	internal WriteBufferHelper writeBufferHelper; //Field offset: 0x8

	internal CodedOutputStream CodedOutputStream
	{
		internal get { } //Length: 5
	}

	internal CodedOutputStream get_CodedOutputStream() { }

}

