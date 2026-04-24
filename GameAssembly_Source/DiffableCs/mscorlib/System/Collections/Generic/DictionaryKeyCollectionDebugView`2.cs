namespace System.Collections.Generic;

internal sealed class DictionaryKeyCollectionDebugView
{
	private readonly ICollection<TKey> _collection; //Field offset: 0x0

	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public TKey[] Items
	{
		 get { } //Length: 226
	}

	public DictionaryKeyCollectionDebugView`2(ICollection<TKey> collection) { }

	public TKey[] get_Items() { }

}

