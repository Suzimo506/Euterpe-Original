namespace System.Collections.ObjectModel;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DebuggerTypeProxy(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class KeyedCollection : Collection<TItem>
{
	private IEqualityComparer<TKey> comparer; //Field offset: 0x0
	private Dictionary<TKey, TItem> dict; //Field offset: 0x0
	private int keyCount; //Field offset: 0x0
	private int threshold; //Field offset: 0x0

	protected IDictionary<TKey, TItem> Dictionary
	{
		 get { } //Length: 5
	}

	public TItem Item
	{
		 get { } //Length: 619
	}

	protected KeyedCollection`2() { }

	protected KeyedCollection`2(IEqualityComparer<TKey> comparer) { }

	protected KeyedCollection`2(IEqualityComparer<TKey> comparer, int dictionaryCreationThreshold) { }

	private void AddKey(TKey key, TItem item) { }

	protected virtual void ClearItems() { }

	public bool Contains(TKey key) { }

	private void CreateDictionary() { }

	protected IDictionary<TKey, TItem> get_Dictionary() { }

	public TItem get_Item(TKey key) { }

	protected abstract TKey GetKeyForItem(TItem item) { }

	protected virtual void InsertItem(int index, TItem item) { }

	protected virtual void RemoveItem(int index) { }

	private void RemoveKey(TKey key) { }

	protected virtual void SetItem(int index, TItem item) { }

}

