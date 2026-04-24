namespace Spine.Collections;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DebuggerTypeProxy(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class OrderedDictionary : IDictionary<TKey, TValue>, ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable, IList<KeyValuePair`2<TKey, TValue>>
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__34 : IEnumerator<KeyValuePair`2<TKey, TValue>>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private KeyValuePair<TKey, TValue> <>2__current; //Field offset: 0x0
		public OrderedDictionary<TKey, TValue> <>4__this; //Field offset: 0x0
		private int <startVersion>5__2; //Field offset: 0x0
		private int <index>5__3; //Field offset: 0x0

		private override KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 29
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 86
		}

		[DebuggerHidden]
		public <GetEnumerator>d__34(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, IEnumerable
	{
		private readonly Dictionary<TKey, Int32> dictionary; //Field offset: 0x0

		public override int Count
		{
			 get { } //Length: 43
		}

		[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private override bool System.Collections.Generic.ICollection<TKey>.IsReadOnly
		{
			private get { } //Length: 3
		}

		internal KeyCollection(Dictionary<TKey, Int32> dictionary) { }

		public override void CopyTo(TKey[] array, int arrayIndex) { }

		public override int get_Count() { }

		public override IEnumerator<TKey> GetEnumerator() { }

		[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private override void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }

		[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private override void System.Collections.Generic.ICollection<TKey>.Clear() { }

		[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private override bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }

		private override bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }

		[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private override bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	internal sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable
	{
		private readonly List<TValue> values; //Field offset: 0x0

		public override int Count
		{
			 get { } //Length: 43
		}

		[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private override bool System.Collections.Generic.ICollection<TValue>.IsReadOnly
		{
			private get { } //Length: 3
		}

		internal ValueCollection(List<TValue> values) { }

		public override void CopyTo(TValue[] array, int arrayIndex) { }

		public override int get_Count() { }

		public override IEnumerator<TValue> GetEnumerator() { }

		[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private override void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }

		[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private override void System.Collections.Generic.ICollection<TValue>.Clear() { }

		[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private override bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }

		private override bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }

		[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private override bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private const string CollectionModifiedMessage = "Collection was modified; enumeration operation may not execute."; //Field offset: 0x0
	private const string EditReadOnlyListMessage = "An attempt was made to edit a read-only list."; //Field offset: 0x0
	private const string IndexOutOfRangeMessage = "The index is negative or outside the bounds of the collection."; //Field offset: 0x0
	private readonly Dictionary<TKey, Int32> dictionary; //Field offset: 0x0
	private readonly List<TKey> keys; //Field offset: 0x0
	private readonly List<TValue> values; //Field offset: 0x0
	private int version; //Field offset: 0x0

	public IEqualityComparer<TKey> Comparer
	{
		 get { } //Length: 43
	}

	public override int Count
	{
		 get { } //Length: 46
	}

	public TValue Item
	{
		 get { } //Length: 46
		 set { } //Length: 46
	}

	public override TValue Item
	{
		 get { } //Length: 117
		 set { } //Length: 283
	}

	public KeyCollection<TKey, TValue> Keys
	{
		 get { } //Length: 117
	}

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys
	{
		private get { } //Length: 42
	}

	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values
	{
		private get { } //Length: 42
	}

	private override KeyValuePair<TKey, TValue> System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Item
	{
		private get { } //Length: 223
		private set { } //Length: 655
	}

	public ValueCollection<TKey, TValue> Values
	{
		 get { } //Length: 117
	}

	public OrderedDictionary`2() { }

	public OrderedDictionary`2(int capacity) { }

	public OrderedDictionary`2(IEqualityComparer<TKey> comparer) { }

	public OrderedDictionary`2(int capacity, IEqualityComparer<TKey> comparer) { }

	public override void Add(TKey key, TValue value) { }

	public override void Clear() { }

	public override bool ContainsKey(TKey key) { }

	public IEqualityComparer<TKey> get_Comparer() { }

	public override int get_Count() { }

	public override TValue get_Item(TKey key) { }

	public TValue get_Item(int index) { }

	public KeyCollection<TKey, TValue> get_Keys() { }

	public ValueCollection<TKey, TValue> get_Values() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override IEnumerator<KeyValuePair`2<TKey, TValue>> GetEnumerator() { }

	public TKey GetKey(int index) { }

	public int IndexOf(TKey key) { }

	public void Insert(int index, TKey key, TValue value) { }

	public override bool Remove(TKey key) { }

	public override void RemoveAt(int index) { }

	public void set_Item(int index, TValue value) { }

	public override void set_Item(TKey key, TValue value) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> item) { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> item) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> item) { }

	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	private override KeyValuePair<TKey, TValue> System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Item(int index) { }

	private override int System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IndexOf(KeyValuePair<TKey, TValue> item) { }

	private override void System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Insert(int index, KeyValuePair<TKey, TValue> item) { }

	private override void System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<TKey,TValue>>.set_Item(int index, KeyValuePair<TKey, TValue> value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override bool TryGetValue(TKey key, out TValue value) { }

}

