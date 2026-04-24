namespace System;

internal sealed class MemoryDebugView
{
	private readonly ReadOnlyMemory<T> _memory; //Field offset: 0x0

	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public T[] Items
	{
		 get { } //Length: 24
	}

	public MemoryDebugView`1(Memory<T> memory) { }

	public MemoryDebugView`1(ReadOnlyMemory<T> memory) { }

	public T[] get_Items() { }

}

