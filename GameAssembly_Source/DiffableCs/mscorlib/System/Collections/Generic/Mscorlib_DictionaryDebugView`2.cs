namespace System.Collections.Generic;

internal sealed class Mscorlib_DictionaryDebugView
{
	private IDictionary<K, V> dict; //Field offset: 0x0

	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public KeyValuePair<K, V>[] Items
	{
		 get { } //Length: 316
	}

	public Mscorlib_DictionaryDebugView`2(IDictionary<K, V> dictionary) { }

	public KeyValuePair<K, V>[] get_Items() { }

}

