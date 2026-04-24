namespace System.Collections.Specialized;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class OrderedDictionary : IOrderedDictionary, IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback
{
	private class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private int _objectReturnType; //Field offset: 0x10
		private IEnumerator arrayEnumerator; //Field offset: 0x18

		public override object Current
		{
			 get { } //Length: 507
		}

		public override DictionaryEntry Entry
		{
			 get { } //Length: 256
		}

		public override object Key
		{
			 get { } //Length: 118
		}

		public override object Value
		{
			 get { } //Length: 128
		}

		internal OrderedDictionaryEnumerator(ArrayList array, int objectReturnType) { }

		public override object get_Current() { }

		public override DictionaryEntry get_Entry() { }

		public override object get_Key() { }

		public override object get_Value() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	private class OrderedDictionaryKeyValueCollection : ICollection, IEnumerable
	{
		private ArrayList _objects; //Field offset: 0x10
		private bool isKeys; //Field offset: 0x18

		private override int System.Collections.ICollection.Count
		{
			private get { } //Length: 39
		}

		private override bool System.Collections.ICollection.IsSynchronized
		{
			private get { } //Length: 3
		}

		private override object System.Collections.ICollection.SyncRoot
		{
			private get { } //Length: 39
		}

		public OrderedDictionaryKeyValueCollection(ArrayList array, bool isKeys) { }

		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		private override int System.Collections.ICollection.get_Count() { }

		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		private override object System.Collections.ICollection.get_SyncRoot() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private ArrayList _objectsArray; //Field offset: 0x10
	private Hashtable _objectsTable; //Field offset: 0x18
	private int _initialCapacity; //Field offset: 0x20
	private IEqualityComparer _comparer; //Field offset: 0x28
	private bool _readOnly; //Field offset: 0x30
	private object _syncRoot; //Field offset: 0x38
	private SerializationInfo _siInfo; //Field offset: 0x40

	public override int Count
	{
		 get { } //Length: 45
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 5
	}

	public override object Item
	{
		 get { } //Length: 150
		 set { } //Length: 525
	}

	public override object Item
	{
		 get { } //Length: 54
		 set { } //Length: 632
	}

	public override ICollection Keys
	{
		 get { } //Length: 111
	}

	private ArrayList objectsArray
	{
		private get { } //Length: 122
	}

	private Hashtable objectsTable
	{
		private get { } //Length: 141
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 108
	}

	private override bool System.Collections.IDictionary.IsFixedSize
	{
		private get { } //Length: 5
	}

	public override ICollection Values
	{
		 get { } //Length: 111
	}

	public OrderedDictionary() { }

	public OrderedDictionary(int capacity) { }

	public OrderedDictionary(int capacity, IEqualityComparer comparer) { }

	protected OrderedDictionary(SerializationInfo info, StreamingContext context) { }

	public override void Add(object key, object value) { }

	public override void Clear() { }

	public override bool Contains(object key) { }

	public override void CopyTo(Array array, int index) { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public override object get_Item(int index) { }

	public override object get_Item(object key) { }

	public override ICollection get_Keys() { }

	private ArrayList get_objectsArray() { }

	private Hashtable get_objectsTable() { }

	public override ICollection get_Values() { }

	public override IDictionaryEnumerator GetEnumerator() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private int IndexOfKey(object key) { }

	public override void Insert(int index, object key, object value) { }

	protected override void OnDeserialization(object sender) { }

	public override void Remove(object key) { }

	public override void RemoveAt(int index) { }

	public override void set_Item(int index, object value) { }

	public override void set_Item(object key, object value) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override bool System.Collections.IDictionary.get_IsFixedSize() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

}

