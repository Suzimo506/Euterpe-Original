namespace Google.Protobuf;

internal struct SegmentedBufferHelper
{
	private Nullable<Int32> totalLength; //Field offset: 0x0
	private Enumerator<Byte> readOnlySequenceEnumerator; //Field offset: 0x8
	private CodedInputStream codedInputStream; //Field offset: 0x48

	public CodedInputStream CodedInputStream
	{
		 get { } //Length: 5
	}

	public Nullable<Int32> TotalLength
	{
		 get { } //Length: 4
	}

	private static void CheckCurrentBufferIsEmpty(ref ParserInternalState state) { }

	public CodedInputStream get_CodedInputStream() { }

	public Nullable<Int32> get_TotalLength() { }

	public static void Initialize(CodedInputStream codedInputStream, out SegmentedBufferHelper instance) { }

	public static void Initialize(ReadOnlySequence<Byte> sequence, out SegmentedBufferHelper instance, out ReadOnlySpan<Byte>& firstSpan) { }

	public static bool IsAtEnd(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state) { }

	public static bool IsReachedLimit(ref ParserInternalState state) { }

	public static void PopLimit(ref ParserInternalState state, int oldLimit) { }

	public static int PushLimit(ref ParserInternalState state, int byteLimit) { }

	private static void RecomputeBufferSizeAfterLimit(ref ParserInternalState state) { }

	public bool RefillBuffer(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state, bool mustSucceed) { }

	private bool RefillFromCodedInputStream(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state, bool mustSucceed) { }

	private bool RefillFromReadOnlySequence(ref ReadOnlySpan<Byte>& buffer, ref ParserInternalState state, bool mustSucceed) { }

}

