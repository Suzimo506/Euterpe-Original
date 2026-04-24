namespace System.Buffers;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DebuggerTypeProxy(/*Cpp2IL Warning: missing at least one required parameter*/)]
[IsReadOnly]
public struct ReadOnlySequence
{
	internal struct Enumerator
	{
		private readonly ReadOnlySequence<T> _sequence; //Field offset: 0x0
		private SequencePosition _next; //Field offset: 0x0
		private ReadOnlyMemory<T> _currentMemory; //Field offset: 0x0

		public ReadOnlyMemory<T> Current
		{
			 get { } //Length: 11
		}

		public Enumerator(in ReadOnlySequence<T>& sequence) { }

		public ReadOnlyMemory<T> get_Current() { }

		public bool MoveNext() { }

	}

	private enum SequenceType
	{
		MultiSegment = 0,
		Array = 1,
		MemoryManager = 2,
		String = 3,
		Empty = 4,
	}

	public static readonly ReadOnlySequence<T> Empty; //Field offset: 0x0
	private readonly SequencePosition _sequenceEnd; //Field offset: 0x0
	private readonly SequencePosition _sequenceStart; //Field offset: 0x0

	public SequencePosition End
	{
		 get { } //Length: 11
	}

	public ReadOnlyMemory<T> First
	{
		 get { } //Length: 93
	}

	public bool IsEmpty
	{
		 get { } //Length: 101
	}

	public bool IsSingleSegment
	{
		 get { } //Length: 11
	}

	public long Length
	{
		 get { } //Length: 62
	}

	public SequencePosition Start
	{
		 get { } //Length: 10
	}

	private static ReadOnlySequence`1() { }

	private ReadOnlySequence`1(object startSegment, int startIndexAndFlags, object endSegment, int endIndexAndFlags) { }

	public ReadOnlySequence`1(ReadOnlySequenceSegment<T> startSegment, int startIndex, ReadOnlySequenceSegment<T> endSegment, int endIndex) { }

	public ReadOnlySequence`1(T[] array) { }

	public ReadOnlySequence`1(T[] array, int start, int length) { }

	public ReadOnlySequence`1(ReadOnlyMemory<T> memory) { }

	private void BoundsCheck(uint sliceStartIndex, object sliceStartObject, uint sliceEndIndex, object sliceEndObject) { }

	private void BoundsCheck(in SequencePosition position) { }

	public SequencePosition get_End() { }

	public ReadOnlyMemory<T> get_First() { }

	public bool get_IsEmpty() { }

	public bool get_IsSingleSegment() { }

	public long get_Length() { }

	public SequencePosition get_Start() { }

	private static SequencePosition GetEndPosition(ReadOnlySequenceSegment<T> startSegment, object startObject, int startIndex, object endObject, int endIndex, long length) { }

	public Enumerator<T> GetEnumerator() { }

	private ReadOnlyMemory<T> GetFirstBuffer() { }

	private static int GetIndex(in SequencePosition position) { }

	private long GetLength() { }

	public SequencePosition GetPosition(long offset) { }

	public SequencePosition GetPosition(long offset, SequencePosition origin) { }

	private SequenceType<T> GetSequenceType() { }

	private static bool InRange(uint value, uint start, uint end) { }

	private static bool InRange(ulong value, ulong start, ulong end) { }

	private SequencePosition Seek(in SequencePosition start, in SequencePosition end, long offset, ExceptionArgument argument) { }

	private static SequencePosition SeekMultiSegment(ReadOnlySequenceSegment<T> currentSegment, object endObject, int endIndex, long offset, ExceptionArgument argument) { }

	public ReadOnlySequence<T> Slice(long start, long length) { }

	public ReadOnlySequence<T> Slice(SequencePosition start, long length) { }

	public ReadOnlySequence<T> Slice(long start) { }

	public ReadOnlySequence<T> Slice(SequencePosition start) { }

	public ReadOnlySequence<T> Slice(SequencePosition start, SequencePosition end) { }

	public ReadOnlySequence<T> Slice(SequencePosition start, int length) { }

	public ReadOnlySequence<T> Slice(int start, SequencePosition end) { }

	public ReadOnlySequence<T> Slice(int start, int length) { }

	public ReadOnlySequence<T> Slice(long start, SequencePosition end) { }

	private ReadOnlySequence<T> SliceImpl(in SequencePosition start, in SequencePosition end) { }

	public virtual string ToString() { }

	public bool TryGet(ref SequencePosition position, out ReadOnlyMemory<T>& memory, bool advance = true) { }

	internal bool TryGetArray(out ArraySegment<T>& segment) { }

	internal bool TryGetBuffer(in SequencePosition position, out ReadOnlyMemory<T>& memory, out SequencePosition next) { }

	internal bool TryGetReadOnlySequenceSegment(out ReadOnlySequenceSegment<T>& startSegment, out int startIndex, out ReadOnlySequenceSegment<T>& endSegment, out int endIndex) { }

	internal bool TryGetString(out string text, out int start, out int length) { }

}

