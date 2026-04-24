namespace System.Collections;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DebuggerTypeProxy(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class SortedList : IDictionary, ICollection, IEnumerable, ICloneable
{
	[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private class KeyList : IList, ICollection, IEnumerable
	{
		private SortedList sortedList; //Field offset: 0x10

		public override int Count
		{
			 get { } //Length: 26
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
			 get { } //Length: 39
		}

		public override object Item
		{
			 get { } //Length: 39
			 set { } //Length: 98
		}

		public override object SyncRoot
		{
			 get { } //Length: 39
		}

		internal KeyList(SortedList sortedList) { }

		public override int Add(object key) { }

		public override void Clear() { }

		public override bool Contains(object key) { }

		public override void CopyTo(Array array, int arrayIndex) { }

		public override int get_Count() { }

		public override bool get_IsFixedSize() { }

		public override bool get_IsReadOnly() { }

		public override bool get_IsSynchronized() { }

		public override object get_Item(int index) { }

		public override object get_SyncRoot() { }

		public override IEnumerator GetEnumerator() { }

		public override int IndexOf(object key) { }

		public override void Insert(int index, object value) { }

		public override void Remove(object key) { }

		public override void RemoveAt(int index) { }

		public override void set_Item(int index, object value) { }

	}

	public class SortedListDebugView
	{
		private SortedList sortedList; //Field offset: 0x10

		[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public KeyValuePairs[] Items
		{
			 get { } //Length: 39
		}

		public SortedListDebugView(SortedList sortedList) { }

		public KeyValuePairs[] get_Items() { }

	}

	private class SortedListEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable
	{
		private SortedList sortedList; //Field offset: 0x10
		private object key; //Field offset: 0x18
		private object value; //Field offset: 0x20
		private int index; //Field offset: 0x28
		private int startIndex; //Field offset: 0x2C
		private int endIndex; //Field offset: 0x30
		private int version; //Field offset: 0x34
		private bool current; //Field offset: 0x38
		private int getObjectRetType; //Field offset: 0x3C

		public override object Current
		{
			 get { } //Length: 243
		}

		public override DictionaryEntry Entry
		{
			 get { } //Length: 255
		}

		public override object Key
		{
			 get { } //Length: 208
		}

		public override object Value
		{
			 get { } //Length: 208
		}

		internal SortedListEnumerator(SortedList sortedList, int index, int count, int getObjRetType) { }

		public override object Clone() { }

		public override object get_Current() { }

		public override DictionaryEntry get_Entry() { }

		public override object get_Key() { }

		public override object get_Value() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private class SyncSortedList : SortedList
	{
		private SortedList _list; //Field offset: 0x48
		private object _root; //Field offset: 0x50

		public virtual int Capacity
		{
			 get { } //Length: 165
		}

		public virtual int Count
		{
			 get { } //Length: 165
		}

		public virtual bool IsFixedSize
		{
			 get { } //Length: 39
		}

		public virtual bool IsReadOnly
		{
			 get { } //Length: 39
		}

		public virtual bool IsSynchronized
		{
			 get { } //Length: 3
		}

		public virtual object Item
		{
			 get { } //Length: 186
			 set { } //Length: 182
		}

		public virtual object SyncRoot
		{
			 get { } //Length: 5
		}

		internal SyncSortedList(SortedList list) { }

		public virtual void Add(object key, object value) { }

		public virtual void Clear() { }

		public virtual object Clone() { }

		public virtual bool Contains(object key) { }

		public virtual bool ContainsKey(object key) { }

		public virtual bool ContainsValue(object key) { }

		public virtual void CopyTo(Array array, int index) { }

		public virtual int get_Capacity() { }

		public virtual int get_Count() { }

		public virtual bool get_IsFixedSize() { }

		public virtual bool get_IsReadOnly() { }

		public virtual bool get_IsSynchronized() { }

		public virtual object get_Item(object key) { }

		public virtual object get_SyncRoot() { }

		public virtual object GetByIndex(int index) { }

		public virtual IDictionaryEnumerator GetEnumerator() { }

		public virtual object GetKey(int index) { }

		public virtual IList GetKeyList() { }

		public virtual IList GetValueList() { }

		public virtual int IndexOfKey(object key) { }

		public virtual int IndexOfValue(object value) { }

		public virtual void Remove(object key) { }

		public virtual void RemoveAt(int index) { }

		public virtual void set_Item(object key, object value) { }

		internal virtual KeyValuePairs[] ToKeyValuePairsArray() { }

	}

	[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private class ValueList : IList, ICollection, IEnumerable
	{
		private SortedList sortedList; //Field offset: 0x10

		public override int Count
		{
			 get { } //Length: 26
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
			 get { } //Length: 39
		}

		public override object Item
		{
			 get { } //Length: 39
			 set { } //Length: 98
		}

		public override object SyncRoot
		{
			 get { } //Length: 39
		}

		internal ValueList(SortedList sortedList) { }

		public override int Add(object key) { }

		public override void Clear() { }

		public override bool Contains(object value) { }

		public override void CopyTo(Array array, int arrayIndex) { }

		public override int get_Count() { }

		public override bool get_IsFixedSize() { }

		public override bool get_IsReadOnly() { }

		public override bool get_IsSynchronized() { }

		public override object get_Item(int index) { }

		public override object get_SyncRoot() { }

		public override IEnumerator GetEnumerator() { }

		public override int IndexOf(object value) { }

		public override void Insert(int index, object value) { }

		public override void Remove(object value) { }

		public override void RemoveAt(int index) { }

		public override void set_Item(int index, object value) { }

	}

	private const int _defaultCapacity = 16; //Field offset: 0x0
	private static Object[] emptyArray; //Field offset: 0x0
	private Object[] keys; //Field offset: 0x10
	private Object[] values; //Field offset: 0x18
	private int _size; //Field offset: 0x20
	private int version; //Field offset: 0x24
	private IComparer comparer; //Field offset: 0x28
	private KeyList keyList; //Field offset: 0x30
	private ValueList valueList; //Field offset: 0x38
	private object _syncRoot; //Field offset: 0x40

	public override int Capacity
	{
		 get { } //Length: 26
		 set { } //Length: 439
	}

	public override int Count
	{
		 get { } //Length: 4
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
		 get { } //Length: 86
		 set { } //Length: 332
	}

	public override ICollection Keys
	{
		 get { } //Length: 17
	}

	public override object SyncRoot
	{
		 get { } //Length: 105
	}

	public override ICollection Values
	{
		 get { } //Length: 17
	}

	private static SortedList() { }

	public SortedList(IComparer comparer, int capacity) { }

	public SortedList(IComparer comparer) { }

	public SortedList() { }

	public SortedList(int initialCapacity) { }

	public override void Add(object key, object value) { }

	public override void Clear() { }

	public override object Clone() { }

	public override bool Contains(object key) { }

	public override bool ContainsKey(object key) { }

	public override bool ContainsValue(object value) { }

	public override void CopyTo(Array array, int arrayIndex) { }

	private void EnsureCapacity(int min) { }

	public override int get_Capacity() { }

	public override int get_Count() { }

	public override bool get_IsFixedSize() { }

	public override bool get_IsReadOnly() { }

	public override bool get_IsSynchronized() { }

	public override object get_Item(object key) { }

	public override ICollection get_Keys() { }

	public override object get_SyncRoot() { }

	public override ICollection get_Values() { }

	public override object GetByIndex(int index) { }

	public override IDictionaryEnumerator GetEnumerator() { }

	public override object GetKey(int index) { }

	public override IList GetKeyList() { }

	public override IList GetValueList() { }

	public override int IndexOfKey(object key) { }

	public override int IndexOfValue(object value) { }

	private void Init() { }

	private void Insert(int index, object key, object value) { }

	public override void Remove(object key) { }

	public override void RemoveAt(int index) { }

	public override void set_Capacity(int value) { }

	public override void set_Item(object key, object value) { }

	public static SortedList Synchronized(SortedList list) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	internal override KeyValuePairs[] ToKeyValuePairsArray() { }

}

