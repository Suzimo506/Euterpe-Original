namespace System.Collections.Generic;

public struct KeyValuePair
{
	private TKey key; //Field offset: 0x0
	private TValue value; //Field offset: 0x0

	public TKey Key
	{
		 get { } //Length: 10
	}

	public TValue Value
	{
		 get { } //Length: 19
	}

	public KeyValuePair`2(TKey key, TValue value) { }

	public TKey get_Key() { }

	public TValue get_Value() { }

	public virtual string ToString() { }

}

