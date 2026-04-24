namespace Spine.Collections;

internal class OrderedDictionaryDebugView
{
	private readonly OrderedDictionary<TKey, TValue> dictionary; //Field offset: 0x0

	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public KeyValuePair<TKey, TValue>[] Items
	{
		 get { } //Length: 24
	}

	public OrderedDictionaryDebugView`2(OrderedDictionary<TKey, TValue> dictionary) { }

	public KeyValuePair<TKey, TValue>[] get_Items() { }

}

