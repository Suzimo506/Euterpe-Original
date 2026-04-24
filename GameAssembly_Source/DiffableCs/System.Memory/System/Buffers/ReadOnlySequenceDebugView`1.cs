namespace System.Buffers;

internal sealed class ReadOnlySequenceDebugView
{
	[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal struct ReadOnlySequenceDebugViewSegments
	{
		[CompilerGenerated]
		private ReadOnlyMemory<T>[] <Segments>k__BackingField; //Field offset: 0x0

		[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public ReadOnlyMemory<T>[] Segments
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 8
		}

		[CompilerGenerated]
		public ReadOnlyMemory<T>[] get_Segments() { }

		[CompilerGenerated]
		public void set_Segments(ReadOnlyMemory<T>[] value) { }

	}

	private readonly T[] _array; //Field offset: 0x0
	private readonly ReadOnlySequenceDebugViewSegments<T> _segments; //Field offset: 0x0

	public ReadOnlySequenceDebugViewSegments<T> BufferSegments
	{
		 get { } //Length: 5
	}

	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public T[] Items
	{
		 get { } //Length: 5
	}

	public ReadOnlySequenceDebugView`1(ReadOnlySequence<T> sequence) { }

	public ReadOnlySequenceDebugViewSegments<T> get_BufferSegments() { }

	public T[] get_Items() { }

}

