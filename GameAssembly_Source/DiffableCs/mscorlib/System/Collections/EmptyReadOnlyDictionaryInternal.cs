namespace System.Collections;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal sealed class EmptyReadOnlyDictionaryInternal : IDictionary, ICollection, IEnumerable
{
	private sealed class NodeEnumerator : IDictionaryEnumerator, IEnumerator
	{

		public override object Current
		{
			 get { } //Length: 98
		}

		public override DictionaryEntry Entry
		{
			 get { } //Length: 98
		}

		public override object Key
		{
			 get { } //Length: 98
		}

		public override object Value
		{
			 get { } //Length: 98
		}

		public NodeEnumerator() { }

		public override object get_Current() { }

		public override DictionaryEntry get_Entry() { }

		public override object get_Key() { }

		public override object get_Value() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}


	public override int Count
	{
		 get { } //Length: 3
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
		 get { } //Length: 127
		 set { } //Length: 419
	}

	public override ICollection Keys
	{
		 get { } //Length: 86
	}

	public override object SyncRoot
	{
		 get { } //Length: 4
	}

	public override ICollection Values
	{
		 get { } //Length: 86
	}

	public EmptyReadOnlyDictionaryInternal() { }

	public override void Add(object key, object value) { }

	public override void Clear() { }

	public override bool Contains(object key) { }

	public override void CopyTo(Array array, int index) { }

	public override int get_Count() { }

	public override bool get_IsFixedSize() { }

	public override bool get_IsReadOnly() { }

	public override bool get_IsSynchronized() { }

	public override object get_Item(object key) { }

	public override ICollection get_Keys() { }

	public override object get_SyncRoot() { }

	public override ICollection get_Values() { }

	public override IDictionaryEnumerator GetEnumerator() { }

	public override void Remove(object key) { }

	public override void set_Item(object key, object value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

