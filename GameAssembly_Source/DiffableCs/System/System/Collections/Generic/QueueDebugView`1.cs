namespace System.Collections.Generic;

internal sealed class QueueDebugView
{
	private readonly Queue<T> _queue; //Field offset: 0x0

	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public T[] Items
	{
		 get { } //Length: 42
	}

	public QueueDebugView`1(Queue<T> queue) { }

	public T[] get_Items() { }

}

