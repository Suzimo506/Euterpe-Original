namespace Rewired.Utils.Classes.Data;

[CustomClassObfuscation]
[CustomObfuscation]
[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class IndexedDictionary : IEnumerable, IDictionary, ICollection, IDictionary<TKey, TValue>, ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IReadOnlyList<TValue>, IReadOnlyList
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal struct Enumerator : IDisposable, IEnumerator, IDictionaryEnumerator, IEnumerator<KeyValuePair`2<TKey, TValue>>
	{
		internal const int DictEntry = 1; //Field offset: 0x0
		internal const int KeyValuePair = 2; //Field offset: 0x0
		private IndexedDictionary<TKey, TValue> hmIsuJDYfljdlpPLNybcFBRgvOUS; //Field offset: 0x0
		private int ZOWgSfXmBWbQJWNoDFYBGQJdNHuGb; //Field offset: 0x0
		private int GjPpSBHArrBPppWJJfrRkGPhkxEGA; //Field offset: 0x0
		private KeyValuePair<TKey, TValue> RBNngEyRausHCyQGCZHTYRuPppaE; //Field offset: 0x0
		private int wMDghdKDuvjuxPpJncaAHKLPmmWGb; //Field offset: 0x0

		public override KeyValuePair<TKey, TValue> Current
		{
			 get { } //Length: 11
		}

		private override DictionaryEntry System.Collections.IDictionaryEnumerator.Entry
		{
			private get { } //Length: 311
		}

		private override object System.Collections.IDictionaryEnumerator.Key
		{
			private get { } //Length: 245
		}

		private override object System.Collections.IDictionaryEnumerator.Value
		{
			private get { } //Length: 155
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 519
		}

		internal Enumerator(IndexedDictionary<TKey, TValue> unnamed_param_0, int unnamed_param_1) { }

		public override void Dispose() { }

		public override KeyValuePair<TKey, TValue> get_Current() { }

		public override bool MoveNext() { }

		private override DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

		private override object System.Collections.IDictionaryEnumerator.get_Key() { }

		private override object System.Collections.IDictionaryEnumerator.get_Value() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

	}

	[CustomClassObfuscation]
	[CustomObfuscation]
	internal sealed class KeyCollection : IEnumerable, IEnumerable<TKey>, ICollection, ICollection<TKey>
	{
		[CustomClassObfuscation]
		[CustomObfuscation]
		internal struct Enumerator : IDisposable, IEnumerator, IEnumerator<TKey>
		{
			private IndexedDictionary<TKey, TValue> hmIsuJDYfljdlpPLNybcFBRgvOUS; //Field offset: 0x0
			private int GjPpSBHArrBPppWJJfrRkGPhkxEGA; //Field offset: 0x0
			private int ZOWgSfXmBWbQJWNoDFYBGQJdNHuGb; //Field offset: 0x0
			private TKey RwcQmeKzIFsSjsNhfssqYlZDMorG; //Field offset: 0x0

			public override TKey Current
			{
				 get { } //Length: 4
			}

			private override object System.Collections.IEnumerator.Current
			{
				private get { } //Length: 210
			}

			internal Enumerator(IndexedDictionary<TKey, TValue> unnamed_param_0) { }

			public override void Dispose() { }

			public override TKey get_Current() { }

			public override bool MoveNext() { }

			private override object System.Collections.IEnumerator.get_Current() { }

			private override void System.Collections.IEnumerator.Reset() { }

		}

		private IndexedDictionary<TKey, TValue> hmIsuJDYfljdlpPLNybcFBRgvOUS; //Field offset: 0x0

		public override int Count
		{
			 get { } //Length: 43
		}

		private override bool System.Collections.Generic.ICollection<TKey>.IsReadOnly
		{
			private get { } //Length: 3
		}

		private override bool System.Collections.ICollection.IsSynchronized
		{
			private get { } //Length: 3
		}

		private override object System.Collections.ICollection.SyncRoot
		{
			private get { } //Length: 72
		}

		public KeyCollection(IndexedDictionary<TKey, TValue> unnamed_param_0) { }

		public override void CopyTo(TKey[] array, int index) { }

		public override int get_Count() { }

		public Enumerator<TKey, TValue> GetEnumerator() { }

		private override void System.Collections.Generic.ICollection<TKey>.Add(TKey unnamed_param_0) { }

		private override void System.Collections.Generic.ICollection<TKey>.Clear() { }

		private override bool System.Collections.Generic.ICollection<TKey>.Contains(TKey unnamed_param_0) { }

		private override bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }

		private override bool System.Collections.Generic.ICollection<TKey>.Remove(TKey unnamed_param_0) { }

		private override IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }

		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		private override object System.Collections.ICollection.get_SyncRoot() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private struct sSLJskWWZUaRAaVZeneXMEYpxZSB
	{
		public  vscCUjoRjTHdZrSaYXPkwnGfcvICA; //Field offset: 0x0
		public  zRUQZDXXBkLNTaHWFlnOtpiXDsdt; //Field offset: 0x0

		public sSLJskWWZUaRAaVZeneXMEYpxZSB( unnamed_param_0,  unnamed_param_1) { }

		public KeyValuePair<, > bDYUSeTJLVmAbGFxchceoCGMzeuh() { }

	}

	[CustomClassObfuscation]
	[CustomObfuscation]
	internal sealed class ValueCollection : IEnumerable, ICollection, ICollection<TValue>, IEnumerable<TValue>
	{
		[CustomClassObfuscation]
		[CustomObfuscation]
		internal struct Enumerator : IDisposable, IEnumerator, IEnumerator<TValue>
		{
			private IndexedDictionary<TKey, TValue> hmIsuJDYfljdlpPLNybcFBRgvOUS; //Field offset: 0x0
			private int GjPpSBHArrBPppWJJfrRkGPhkxEGA; //Field offset: 0x0
			private int ZOWgSfXmBWbQJWNoDFYBGQJdNHuGb; //Field offset: 0x0
			private TValue MbkCKDHhTBcHPhhOEuIiCcGzLpeJb; //Field offset: 0x0

			public override TValue Current
			{
				 get { } //Length: 5
			}

			private override object System.Collections.IEnumerator.Current
			{
				private get { } //Length: 125
			}

			internal Enumerator(IndexedDictionary<TKey, TValue> unnamed_param_0) { }

			public override void Dispose() { }

			public override TValue get_Current() { }

			public override bool MoveNext() { }

			private override object System.Collections.IEnumerator.get_Current() { }

			private override void System.Collections.IEnumerator.Reset() { }

		}

		private IndexedDictionary<TKey, TValue> hmIsuJDYfljdlpPLNybcFBRgvOUS; //Field offset: 0x0

		public override int Count
		{
			 get { } //Length: 43
		}

		private override bool System.Collections.Generic.ICollection<TValue>.IsReadOnly
		{
			private get { } //Length: 3
		}

		private override bool System.Collections.ICollection.IsSynchronized
		{
			private get { } //Length: 3
		}

		private override object System.Collections.ICollection.SyncRoot
		{
			private get { } //Length: 72
		}

		public ValueCollection(IndexedDictionary<TKey, TValue> unnamed_param_0) { }

		public override void CopyTo(TValue[] array, int index) { }

		public override int get_Count() { }

		public Enumerator<TKey, TValue> GetEnumerator() { }

		private override void System.Collections.Generic.ICollection<TValue>.Add(TValue unnamed_param_0) { }

		private override void System.Collections.Generic.ICollection<TValue>.Clear() { }

		private override bool System.Collections.Generic.ICollection<TValue>.Contains(TValue unnamed_param_0) { }

		private override bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }

		private override bool System.Collections.Generic.ICollection<TValue>.Remove(TValue unnamed_param_0) { }

		private override IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		private override object System.Collections.ICollection.get_SyncRoot() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private static readonly bool sDSFrjirBqIgffrLYmMBQyjDLXYn; //Field offset: 0x0
	private static readonly bool QGoWaEixSoaeLDpkqYutwqgjemZA; //Field offset: 0x0
	private IEqualityComparer<TKey> yTZAGWgGuVJcgtoZsYonptyrGOlj; //Field offset: 0x0
	private IEqualityComparer<TValue> ESMcuacUjJrJLBVCjNVqmkzKpeLvA; //Field offset: 0x0
	private readonly AList<sSLJskWWZUaRAaVZeneXMEYpxZSB<TKey, TValue>> mECxxWkCqbkiOJrUgGqXCWtkklh; //Field offset: 0x0
	private readonly ADictionary<TKey, Int32> OUEMkKbhLpKjFAbcURhGOQPLDuhe; //Field offset: 0x0
	private bool ljbNXsRYoYoJHnVnLHVWSjFiDJvs; //Field offset: 0x0

	public bool AllowDuplicateKeys
	{
		 get { } //Length: 5
		 set { } //Length: 153
	}

	public bool ContainsDuplicateKeys
	{
		 get { } //Length: 54
	}

	public override int Count
	{
		 get { } //Length: 26
	}

	public TValue Item
	{
		 get { } //Length: 163
		 set { } //Length: 189
	}

	public IEqualityComparer<TKey> KeyComparer
	{
		 get { } //Length: 5
		 set { } //Length: 57
	}

	public override ICollection<TKey> Keys
	{
		 get { } //Length: 116
	}

	private override int Rewired.Utils.Interfaces.IReadOnlyList.Count
	{
		private get { } //Length: 42
	}

	private override object Rewired.Utils.Interfaces.IReadOnlyList.Item
	{
		private get { } //Length: 42
	}

	private override TValue Rewired.Utils.Interfaces.IReadOnlyList<TValue>.Item
	{
		private get { } //Length: 42
	}

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override TValue System.Collections.Generic.IDictionary<TKey,TValue>.Item
	{
		private get { } //Length: 249
		private set { } //Length: 42
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 72
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 72
	}

	private override bool System.Collections.IDictionary.IsFixedSize
	{
		private get { } //Length: 3
	}

	private override bool System.Collections.IDictionary.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override object System.Collections.IDictionary.Item
	{
		private get { } //Length: 280
		private set { } //Length: 389
	}

	private override ICollection System.Collections.IDictionary.Keys
	{
		private get { } //Length: 116
	}

	private override ICollection System.Collections.IDictionary.Values
	{
		private get { } //Length: 116
	}

	public IEqualityComparer<TValue> ValueComparer
	{
		 get { } //Length: 5
		 set { } //Length: 57
	}

	public override ICollection<TValue> Values
	{
		 get { } //Length: 116
	}

	private static IndexedDictionary`2() { }

	public IndexedDictionary`2(IDictionary<TKey, TValue> unnamed_param_0, bool unnamed_param_1) { }

	public IndexedDictionary`2(IDictionary<TKey, TValue> unnamed_param_0) { }

	public IndexedDictionary`2() { }

	public IndexedDictionary`2(int unnamed_param_0) { }

	public IndexedDictionary`2(bool unnamed_param_0) { }

	public IndexedDictionary`2(int unnamed_param_0, bool unnamed_param_1) { }

	public override void Add(TKey key, TValue value) { }

	public override void Clear() { }

	public override bool ContainsKey(TKey key) { }

	public bool ContainsValue(TValue value) { }

	private override int DCFjIzfjemhveDzjApetyiYrJHpy(object unnamed_param_0) { }

	public bool get_AllowDuplicateKeys() { }

	public bool get_ContainsDuplicateKeys() { }

	public override int get_Count() { }

	public TValue get_Item(int index) { }

	public IEqualityComparer<TKey> get_KeyComparer() { }

	public override ICollection<TKey> get_Keys() { }

	public IEqualityComparer<TValue> get_ValueComparer() { }

	public override ICollection<TValue> get_Values() { }

	public KeyValuePair<TKey, TValue> GetEntry(TKey key) { }

	public KeyValuePair<TKey, TValue> GetEntryAt(int index) { }

	public override IEnumerator<KeyValuePair`2<TKey, TValue>> GetEnumerator() { }

	public TKey GetKeyAt(int index) { }

	public TValue GetValue(TKey key) { }

	private override bool IHdaMzBIsrMQVCFbMhpfskjqaCajA(object unnamed_param_0) { }

	public int IndexOfKey(TKey key) { }

	public int IndexOfValue(TValue value) { }

	private override object IwZBquWJLEeISYTuRfOJuVjPSEvf(int unnamed_param_0) { }

	public override bool Remove(TKey key) { }

	public int RemoveAll(TValue value) { }

	public void RemoveAt(int index) { }

	public void RemoveValue(TValue value) { }

	private override bool Rewired.Utils.Interfaces.IReadOnlyList<TValue>.Contains(TValue unnamed_param_0) { }

	private override TValue Rewired.Utils.Interfaces.IReadOnlyList<TValue>.get_Item(int unnamed_param_0) { }

	private override int Rewired.Utils.Interfaces.IReadOnlyList<TValue>.IndexOf(TValue unnamed_param_0) { }

	public void set_AllowDuplicateKeys(bool value) { }

	public void set_Item(int index, TValue value) { }

	public void set_KeyComparer(IEqualityComparer<TKey> value) { }

	public void set_ValueComparer(IEqualityComparer<TValue> value) { }

	public void SetValue(TKey key, TValue value) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> unnamed_param_0) { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> unnamed_param_0) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] unnamed_param_0, int unnamed_param_1) { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> unnamed_param_0) { }

	private override TValue System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(TKey unnamed_param_0) { }

	private override void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(TKey unnamed_param_0, TValue unnamed_param_1) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override void System.Collections.IDictionary.Add(object key, object value) { }

	private override bool System.Collections.IDictionary.Contains(object key) { }

	private override bool System.Collections.IDictionary.get_IsFixedSize() { }

	private override bool System.Collections.IDictionary.get_IsReadOnly() { }

	private override object System.Collections.IDictionary.get_Item(object key) { }

	private override ICollection System.Collections.IDictionary.get_Keys() { }

	private override ICollection System.Collections.IDictionary.get_Values() { }

	private override IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	private override void System.Collections.IDictionary.Remove(object key) { }

	private override void System.Collections.IDictionary.set_Item(object key, object value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public void TrimExcess() { }

	public bool TryGetEntry(TKey key, out KeyValuePair<TKey, TValue>& entry) { }

	public override bool TryGetValue(TKey key, out TValue value) { }

	private override int YiqSZAfYIHSWnKjCkEUGJLewcRpV() { }

}

