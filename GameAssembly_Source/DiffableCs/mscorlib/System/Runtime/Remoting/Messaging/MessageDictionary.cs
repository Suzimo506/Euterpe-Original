namespace System.Runtime.Remoting.Messaging;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class MessageDictionary : IDictionary, ICollection, IEnumerable
{
	private class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private MessageDictionary _methodDictionary; //Field offset: 0x10
		private IDictionaryEnumerator _hashtableEnum; //Field offset: 0x18
		private int _posMethod; //Field offset: 0x20

		public override object Current
		{
			 get { } //Length: 83
		}

		public override DictionaryEntry Entry
		{
			 get { } //Length: 364
		}

		public override object Key
		{
			 get { } //Length: 28
		}

		public override object Value
		{
			 get { } //Length: 38
		}

		public DictionaryEnumerator(MessageDictionary methodDictionary) { }

		public override object get_Current() { }

		public override DictionaryEntry get_Entry() { }

		public override object get_Key() { }

		public override object get_Value() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	private IDictionary _internalProperties; //Field offset: 0x10
	protected IMethodMessage _message; //Field offset: 0x18
	private String[] _methodKeys; //Field offset: 0x20
	private bool _ownProperties; //Field offset: 0x28

	public override int Count
	{
		 get { } //Length: 105
	}

	internal IDictionary InternalDictionary
	{
		internal get { } //Length: 255
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
		 get { } //Length: 273
		 set { } //Length: 343
	}

	public override ICollection Keys
	{
		 get { } //Length: 812
	}

	public String[] MethodKeys
	{
		 set { } //Length: 12
	}

	public override object SyncRoot
	{
		 get { } //Length: 4
	}

	public override ICollection Values
	{
		 get { } //Length: 879
	}

	public MessageDictionary(IMethodMessage message) { }

	public override void Add(object key, object value) { }

	protected override IDictionary AllocInternalProperties() { }

	public override void Clear() { }

	public override bool Contains(object key) { }

	public override void CopyTo(Array array, int index) { }

	public override int get_Count() { }

	internal IDictionary get_InternalDictionary() { }

	public override bool get_IsFixedSize() { }

	public override bool get_IsReadOnly() { }

	public override bool get_IsSynchronized() { }

	public override object get_Item(object key) { }

	public override ICollection get_Keys() { }

	public override object get_SyncRoot() { }

	public override ICollection get_Values() { }

	public override IDictionaryEnumerator GetEnumerator() { }

	public IDictionary GetInternalProperties() { }

	protected override object GetMethodProperty(string key) { }

	internal bool HasUserData() { }

	private bool IsOverridenKey(string key) { }

	public override void Remove(object key) { }

	public override void set_Item(object key, object value) { }

	public void set_MethodKeys(String[] value) { }

	protected override void SetMethodProperty(string key, object value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

