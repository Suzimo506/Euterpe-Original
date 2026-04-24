namespace System.Collections.Generic;

internal sealed class DictionaryValueCollectionDebugView
{
	private readonly ICollection<TValue> _collection; //Field offset: 0x0

	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public TValue[] Items
	{
		 get { } //Length: 226
	}

	public DictionaryValueCollectionDebugView`2(ICollection<TValue> collection) { }

	public TValue[] get_Items() { }

}

