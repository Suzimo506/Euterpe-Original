namespace System.Collections.Specialized;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class HybridDictionary : IDictionary, ICollection, IEnumerable
{
	private ListDictionary list; //Field offset: 0x10
	private Hashtable hashtable; //Field offset: 0x18
	private bool caseInsensitive; //Field offset: 0x20

	public override int Count
	{
		 get { } //Length: 43
	}

	public override bool IsFixedSize
	{
		 get { } //Length: 3
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public override bool IsSynchronized
	{
		 get { } //Length: 3
	}

	public override object Item
	{
		 get { } //Length: 460
		 set { } //Length: 334
	}

	public override ICollection Keys
	{
		 get { } //Length: 159
	}

	private ListDictionary List
	{
		private get { } //Length: 179
	}

	public override object SyncRoot
	{
		 get { } //Length: 4
	}

	public override ICollection Values
	{
		 get { } //Length: 159
	}

	public HybridDictionary() { }

	public HybridDictionary(bool caseInsensitive) { }

	public override void Add(object key, object value) { }

	private void ChangeOver() { }

	public override void Clear() { }

	public override bool Contains(object key) { }

	public override void CopyTo(Array array, int index) { }

	public override int get_Count() { }

	public override bool get_IsFixedSize() { }

	public override bool get_IsReadOnly() { }

	public override bool get_IsSynchronized() { }

	public override object get_Item(object key) { }

	public override ICollection get_Keys() { }

	private ListDictionary get_List() { }

	public override object get_SyncRoot() { }

	public override ICollection get_Values() { }

	public override IDictionaryEnumerator GetEnumerator() { }

	public override void Remove(object key) { }

	public override void set_Item(object key, object value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

