namespace Sirenix.Serialization.Utilities;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class DoubleLookupDictionary : Dictionary<TFirstKey, Dictionary`2<TSecondKey, TValue>>
{
	private readonly IEqualityComparer<TSecondKey> secondKeyComparer; //Field offset: 0x0

	public Dictionary<TSecondKey, TValue> Item
	{
		 get { } //Length: 213
	}

	public DoubleLookupDictionary`3() { }

	public DoubleLookupDictionary`3(IEqualityComparer<TFirstKey> firstKeyComparer, IEqualityComparer<TSecondKey> secondKeyComparer) { }

	public TValue AddInner(TFirstKey firstKey, TSecondKey secondKey, TValue value) { }

	public bool ContainsKeys(TFirstKey firstKey, TSecondKey secondKey) { }

	public Dictionary<TSecondKey, TValue> get_Item(TFirstKey firstKey) { }

	public int InnerCount(TFirstKey firstKey) { }

	public bool RemoveInner(TFirstKey firstKey, TSecondKey secondKey) { }

	public void RemoveWhere(Func<TValue, Boolean> predicate) { }

	public int TotalInnerCount() { }

	public bool TryGetInnerValue(TFirstKey firstKey, TSecondKey secondKey, out TValue value) { }

}

