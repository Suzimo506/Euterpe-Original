namespace Newtonsoft.Json.Utilities;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class DictionaryWrapper : IDictionary<TKey, TValue>, ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable, IWrappedDictionary, IDictionary, ICollection
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public static readonly <>c<TKey, TValue> <>9; //Field offset: 0x0
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public static Func<DictionaryEntry, KeyValuePair`2<TKey, TValue>> <>9__29_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		internal KeyValuePair<TKey, TValue> <GetEnumerator>b__29_0(DictionaryEntry de) { }

	}

	[IsReadOnly]
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private struct DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private readonly IEnumerator<KeyValuePair`2<TEnumeratorKey, TEnumeratorValue>> _e; //Field offset: 0x0

		public override object Current
		{
			 get { } //Length: 553
		}

		public override DictionaryEntry Entry
		{
			 get { } //Length: 162
		}

		public override object Key
		{
			 get { } //Length: 172
		}

		public override object Value
		{
			 get { } //Length: 182
		}

		public DictionaryEnumerator`2(IEnumerator<KeyValuePair`2<TEnumeratorKey, TEnumeratorValue>> e) { }

		public override object get_Current() { }

		public override DictionaryEntry get_Entry() { }

		public override object get_Key() { }

		public override object get_Value() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly IDictionary _dictionary; //Field offset: 0x0
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly IDictionary<TKey, TValue> _genericDictionary; //Field offset: 0x0
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly IReadOnlyDictionary<TKey, TValue> _readOnlyDictionary; //Field offset: 0x0
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private object _syncRoot; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 195
	}

	internal IDictionary<TKey, TValue> GenericDictionary
	{
		internal get { } //Length: 5
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 202
	}

	public override TValue Item
	{
		 get { } //Length: 317
		 set { } //Length: 273
	}

	public override ICollection<TKey> Keys
	{
		 get { } //Length: 324
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 75
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 108
	}

	private override bool System.Collections.IDictionary.IsFixedSize
	{
		private get { } //Length: 102
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private override object System.Collections.IDictionary.Item
	{
		private get { } //Length: 415
		private set { } //Length: 441
	}

	private override ICollection System.Collections.IDictionary.Keys
	{
		private get { } //Length: 240
	}

	private override ICollection System.Collections.IDictionary.Values
	{
		private get { } //Length: 240
	}

	public override object UnderlyingDictionary
	{
		 get { } //Length: 40
	}

	public override ICollection<TValue> Values
	{
		 get { } //Length: 324
	}

	public DictionaryWrapper`2(IDictionary dictionary) { }

	public DictionaryWrapper`2(IDictionary<TKey, TValue> dictionary) { }

	public DictionaryWrapper`2(IReadOnlyDictionary<TKey, TValue> dictionary) { }

	public override void Add(TKey key, TValue value) { }

	public override void Add(KeyValuePair<TKey, TValue> item) { }

	public override void Clear() { }

	public override bool Contains(KeyValuePair<TKey, TValue> item) { }

	public override bool ContainsKey(TKey key) { }

	public override void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }

	public override int get_Count() { }

	internal IDictionary<TKey, TValue> get_GenericDictionary() { }

	public override bool get_IsReadOnly() { }

	public override TValue get_Item(TKey key) { }

	public override ICollection<TKey> get_Keys() { }

	public override object get_UnderlyingDictionary() { }

	public override ICollection<TValue> get_Values() { }

	public override IEnumerator<KeyValuePair`2<TKey, TValue>> GetEnumerator() { }

	public override bool Remove(KeyValuePair<TKey, TValue> item) { }

	public override bool Remove(TKey key) { }

	public override void Remove(object key) { }

	public override void set_Item(TKey key, TValue value) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override void System.Collections.IDictionary.Add(object key, object value) { }

	private override bool System.Collections.IDictionary.Contains(object key) { }

	private override bool System.Collections.IDictionary.get_IsFixedSize() { }

	private override object System.Collections.IDictionary.get_Item(object key) { }

	private override ICollection System.Collections.IDictionary.get_Keys() { }

	private override ICollection System.Collections.IDictionary.get_Values() { }

	private override IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	private override void System.Collections.IDictionary.set_Item(object key, object value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override bool TryGetValue(TKey key, out TValue value) { }

}

