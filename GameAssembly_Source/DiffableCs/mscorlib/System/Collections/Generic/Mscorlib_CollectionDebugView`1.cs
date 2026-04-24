namespace System.Collections.Generic;

internal sealed class Mscorlib_CollectionDebugView
{
	private ICollection<T> collection; //Field offset: 0x0

	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public T[] Items
	{
		 get { } //Length: 316
	}

	public Mscorlib_CollectionDebugView`1(ICollection<T> collection) { }

	public T[] get_Items() { }

}

