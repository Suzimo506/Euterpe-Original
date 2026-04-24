namespace System;

internal sealed class SpanDebugView
{
	private readonly T[] _pinnable; //Field offset: 0x0
	private readonly IntPtr _byteOffset; //Field offset: 0x0
	private readonly int _length; //Field offset: 0x0

	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public T[] Items
	{
		 get { } //Length: 616
	}

	public SpanDebugView`1(Span<T> collection) { }

	public SpanDebugView`1(ReadOnlySpan<T> collection) { }

	public T[] get_Items() { }

}

