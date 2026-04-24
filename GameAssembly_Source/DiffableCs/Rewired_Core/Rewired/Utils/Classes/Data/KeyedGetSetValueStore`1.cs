namespace Rewired.Utils.Classes.Data;

[CustomClassObfuscation]
[CustomObfuscation]
internal sealed class KeyedGetSetValueStore : IEnumerable, IDictionary<TKey, Object>, ICollection<KeyValuePair`2<TKey, Object>>, IEnumerable<KeyValuePair`2<TKey, Object>>
{
	private readonly Dictionary<TKey, Object> uasGypXPLEIXhSwoMRRmRLQEvhSE; //Field offset: 0x0
	private readonly bool JypddVLTREqaKtOCRwXwkUYSLTti; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 42
	}

	public bool isReadOnlyCollection
	{
		 get { } //Length: 5
	}

	private override int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,System.Object>>.Count
	{
		private get { } //Length: 42
	}

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,System.Object>>.IsReadOnly
	{
		private get { } //Length: 5
	}

	private override object System.Collections.Generic.IDictionary<TKey,System.Object>.Item
	{
		private get { } //Length: 46
		private set { } //Length: 121
	}

	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,System.Object>.Keys
	{
		private get { } //Length: 43
	}

	private override ICollection<Object> System.Collections.Generic.IDictionary<TKey,System.Object>.Values
	{
		private get { } //Length: 43
	}

	public KeyedGetSetValueStore`1(Dictionary<TKey, Object> unnamed_param_0, bool unnamed_param_1) { }

	public KeyedGetSetValueStore`1(bool unnamed_param_0) { }

	public void AddItem(TKey key, IGetSetValue<TValue> item) { }

	public void Clear() { }

	public bool ContainsKey(TKey key) { }

	public bool ContainsValue(TKey key) { }

	private static string dQAZnIesaZAFdMdXHpWFuHKgUXmE(TKey unnamed_param_0, Type unnamed_param_1) { }

	public int get_Count() { }

	public bool get_isReadOnlyCollection() { }

	public IGetSetValue<TValue> GetItem(TKey key) { }

	public TValue GetValue(TKey key) { }

	private void MKFbgzDRXcbbFawBgbyCyPkinXbyB() { }

	private static void QihbWNbEmBqymPxnfzLjrWelhPot(TKey unnamed_param_0, Type unnamed_param_1) { }

	public bool RemoveItem(TKey key) { }

	public void SetValue(TKey key, TValue value) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,System.Object>>.Add(KeyValuePair<TKey, Object> unnamed_param_0) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,System.Object>>.Clear() { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,System.Object>>.Contains(KeyValuePair<TKey, Object> unnamed_param_0) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,System.Object>>.CopyTo(KeyValuePair<TKey, Object>[] unnamed_param_0, int unnamed_param_1) { }

	private override int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,System.Object>>.get_Count() { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,System.Object>>.get_IsReadOnly() { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,System.Object>>.Remove(KeyValuePair<TKey, Object> unnamed_param_0) { }

	private override void System.Collections.Generic.IDictionary<TKey,System.Object>.Add(TKey unnamed_param_0, object unnamed_param_1) { }

	private override bool System.Collections.Generic.IDictionary<TKey,System.Object>.ContainsKey(TKey unnamed_param_0) { }

	private override object System.Collections.Generic.IDictionary<TKey,System.Object>.get_Item(TKey unnamed_param_0) { }

	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,System.Object>.get_Keys() { }

	private override ICollection<Object> System.Collections.Generic.IDictionary<TKey,System.Object>.get_Values() { }

	private override bool System.Collections.Generic.IDictionary<TKey,System.Object>.Remove(TKey unnamed_param_0) { }

	private override void System.Collections.Generic.IDictionary<TKey,System.Object>.set_Item(TKey unnamed_param_0, object unnamed_param_1) { }

	private override bool System.Collections.Generic.IDictionary<TKey,System.Object>.TryGetValue(TKey unnamed_param_0, out object unnamed_param_1) { }

	private override IEnumerator<KeyValuePair`2<TKey, Object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,System.Object>>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public bool TryGetValue(TKey key, out TValue value) { }

	public bool TrySetValue(TKey key, TValue value) { }

}

