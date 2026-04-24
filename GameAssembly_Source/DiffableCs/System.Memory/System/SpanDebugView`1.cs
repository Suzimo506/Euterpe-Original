namespace System;

internal sealed class SpanDebugView
{
	private readonly T[] _array; //Field offset: 0x0

	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public T[] Items
	{
		 get { } //Length: 5
	}

	public SpanDebugView`1(Span<T> span) { }

	public SpanDebugView`1(ReadOnlySpan<T> span) { }

	public T[] get_Items() { }

}

