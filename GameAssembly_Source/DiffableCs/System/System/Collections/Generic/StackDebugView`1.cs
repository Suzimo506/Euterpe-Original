namespace System.Collections.Generic;

internal sealed class StackDebugView
{
	private readonly Stack<T> _stack; //Field offset: 0x0

	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public T[] Items
	{
		 get { } //Length: 42
	}

	public StackDebugView`1(Stack<T> stack) { }

	public T[] get_Items() { }

}

