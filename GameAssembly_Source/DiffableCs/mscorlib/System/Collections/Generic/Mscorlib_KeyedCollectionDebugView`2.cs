namespace System.Collections.Generic;

internal sealed class Mscorlib_KeyedCollectionDebugView
{
	private KeyedCollection<K, T> kc; //Field offset: 0x0

	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public T[] Items
	{
		 get { } //Length: 170
	}

	public Mscorlib_KeyedCollectionDebugView`2(KeyedCollection<K, T> keyedCollection) { }

	public T[] get_Items() { }

}

