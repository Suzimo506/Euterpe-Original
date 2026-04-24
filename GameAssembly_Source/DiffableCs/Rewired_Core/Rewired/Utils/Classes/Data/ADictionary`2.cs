namespace Rewired.Utils.Classes.Data;

[CustomClassObfuscation]
[CustomObfuscation]
[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class ADictionary : IEnumerable, IDictionary, ICollection, IDictionary<TKey, TValue>, ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	public struct Entry
	{
		public int hashCode; //Field offset: 0x0
		public int next; //Field offset: 0x0
		public TKey key; //Field offset: 0x0
		public TValue value; //Field offset: 0x0

	}

	[CustomClassObfuscation]
	[CustomObfuscation]
	internal struct Enumerator : IDisposable, IEnumerator, IDictionaryEnumerator, IEnumerator<KeyValuePair`2<TKey, TValue>>
	{
		internal const int DictEntry = 1; //Field offset: 0x0
		internal const int KeyValuePair = 2; //Field offset: 0x0
		private ADictionary<TKey, TValue> hmIsuJDYfljdlpPLNybcFBRgvOUS; //Field offset: 0x0
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
			private get { } //Length: 364
		}

		private override object System.Collections.IDictionaryEnumerator.Key
		{
			private get { } //Length: 228
		}

		private override object System.Collections.IDictionaryEnumerator.Value
		{
			private get { } //Length: 228
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 568
		}

		internal Enumerator(ADictionary<TKey, TValue> unnamed_param_0, int unnamed_param_1) { }

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
			private ADictionary<TKey, TValue> hmIsuJDYfljdlpPLNybcFBRgvOUS; //Field offset: 0x0
			private int GjPpSBHArrBPppWJJfrRkGPhkxEGA; //Field offset: 0x0
			private int ZOWgSfXmBWbQJWNoDFYBGQJdNHuGb; //Field offset: 0x0
			private TKey RwcQmeKzIFsSjsNhfssqYlZDMorG; //Field offset: 0x0

			public override TKey Current
			{
				 get { } //Length: 4
			}

			private override object System.Collections.IEnumerator.Current
			{
				private get { } //Length: 196
			}

			internal Enumerator(ADictionary<TKey, TValue> unnamed_param_0) { }

			public override void Dispose() { }

			public override TKey get_Current() { }

			public override bool MoveNext() { }

			private override object System.Collections.IEnumerator.get_Current() { }

			private override void System.Collections.IEnumerator.Reset() { }

		}

		private ADictionary<TKey, TValue> hmIsuJDYfljdlpPLNybcFBRgvOUS; //Field offset: 0x0

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

		public KeyCollection(ADictionary<TKey, TValue> unnamed_param_0) { }

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

	[CustomClassObfuscation]
	[CustomObfuscation]
	internal sealed class ValueCollection : IEnumerable, ICollection, ICollection<TValue>, IEnumerable<TValue>
	{
		[CustomClassObfuscation]
		[CustomObfuscation]
		internal struct Enumerator : IDisposable, IEnumerator, IEnumerator<TValue>
		{
			private ADictionary<TKey, TValue> hmIsuJDYfljdlpPLNybcFBRgvOUS; //Field offset: 0x0
			private int GjPpSBHArrBPppWJJfrRkGPhkxEGA; //Field offset: 0x0
			private int ZOWgSfXmBWbQJWNoDFYBGQJdNHuGb; //Field offset: 0x0
			private TValue MbkCKDHhTBcHPhhOEuIiCcGzLpeJb; //Field offset: 0x0

			public override TValue Current
			{
				 get { } //Length: 4
			}

			private override object System.Collections.IEnumerator.Current
			{
				private get { } //Length: 196
			}

			internal Enumerator(ADictionary<TKey, TValue> unnamed_param_0) { }

			public override void Dispose() { }

			public override TValue get_Current() { }

			public override bool MoveNext() { }

			private override object System.Collections.IEnumerator.get_Current() { }

			private override void System.Collections.IEnumerator.Reset() { }

		}

		private ADictionary<TKey, TValue> hmIsuJDYfljdlpPLNybcFBRgvOUS; //Field offset: 0x0

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

		public ValueCollection(ADictionary<TKey, TValue> unnamed_param_0) { }

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

	private const string MQAucqVIvVYqaSJmMwNJvdHdmalj = "Comparer"; //Field offset: 0x0
	private const string ExAJqnirfgeXyKibTaUDsxPnVNQb = "HashSize"; //Field offset: 0x0
	private const string GnTmlxKyCsdpDnHfpjHKMvADexGK = "Version"; //Field offset: 0x0
	private static readonly bool QGoWaEixSoaeLDpkqYutwqgjemZA; //Field offset: 0x0
	private static readonly bool sDSFrjirBqIgffrLYmMBQyjDLXYn; //Field offset: 0x0
	private const string CZRjnvWWZPsSgjTLMwlBXAAOaMecA = "KeyValuePairs"; //Field offset: 0x0
	private readonly object JvTepDFBJnRKFvFEmZXdJPiGYFyJA; //Field offset: 0x0
	private ValueCollection<TKey, TValue> SJNnTuagRsUDYwYpfLqSvNFGtaXM; //Field offset: 0x0
	private KeyCollection<TKey, TValue> vYPwiiZVADfavNIFLmGgnFzKqRXv; //Field offset: 0x0
	private IEqualityComparer<TValue> ESMcuacUjJrJLBVCjNVqmkzKpeLvA; //Field offset: 0x0
	private int ljseQheXXFdSOnuZJYDrSpAdGTtyA; //Field offset: 0x0
	private int rStZekcAAmtocjrfRqYuuqJunzMq; //Field offset: 0x0
	private int IvBxtmNHmwKyKSlGmVMvggRscYGe; //Field offset: 0x0
	private int GusbjnNWxeqFGJLFxSjFjcDCeenJ; //Field offset: 0x0
	internal int _count; //Field offset: 0x0
	internal Entry<TKey, TValue>[] _entries; //Field offset: 0x0
	private IEqualityComparer<TKey> yTZAGWgGuVJcgtoZsYonptyrGOlj; //Field offset: 0x0
	private Int32[] AKMNUxtAntPLpsqxTStDfndtSmOq; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 7
	}

	public int IndexOfFirst
	{
		 get { } //Length: 83
	}

	public int IndexOfLast
	{
		 get { } //Length: 85
	}

	public override TValue Item
	{
		 get { } //Length: 238
		 set { } //Length: 44
	}

	public IEqualityComparer<TKey> KeyComparer
	{
		 get { } //Length: 5
		 set { } //Length: 57
	}

	public KeyCollection<TKey, TValue> Keys
	{
		 get { } //Length: 163
	}

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys
	{
		private get { } //Length: 163
	}

	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values
	{
		private get { } //Length: 164
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 5
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
		private get { } //Length: 435
		private set { } //Length: 593
	}

	private override ICollection System.Collections.IDictionary.Keys
	{
		private get { } //Length: 42
	}

	private override ICollection System.Collections.IDictionary.Values
	{
		private get { } //Length: 42
	}

	public int TotalCount
	{
		 get { } //Length: 4
	}

	public IEqualityComparer<TValue> ValueComparer
	{
		 get { } //Length: 5
		 set { } //Length: 57
	}

	public ValueCollection<TKey, TValue> Values
	{
		 get { } //Length: 164
	}

	private static ADictionary`2() { }

	public ADictionary`2(IDictionary<TKey, TValue> unnamed_param_0, IEqualityComparer<TKey> unnamed_param_1, IEqualityComparer<TValue> unnamed_param_2) { }

	public ADictionary`2(IDictionary<TKey, TValue> unnamed_param_0, IEqualityComparer<TKey> unnamed_param_1) { }

	public ADictionary`2(IDictionary<TKey, TValue> unnamed_param_0) { }

	public ADictionary`2() { }

	public ADictionary`2(IEqualityComparer<TKey> unnamed_param_0) { }

	public ADictionary`2(IEqualityComparer<TKey> unnamed_param_0, IEqualityComparer<TValue> unnamed_param_1) { }

	public ADictionary`2(int unnamed_param_0) { }

	public ADictionary`2(int unnamed_param_0, IEqualityComparer<TKey> unnamed_param_1) { }

	public ADictionary`2(int unnamed_param_0, IEqualityComparer<TKey> unnamed_param_1, IEqualityComparer<TValue> unnamed_param_2) { }

	public override void Add(TKey key, TValue value) { }

	public override void Clear() { }

	private void cnKeHmkQcxuiGFzzSHmDurQFUSeaA(int unnamed_param_0) { }

	public override bool ContainsKey(TKey key) { }

	public bool ContainsValue(TValue value) { }

	private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }

	public override int get_Count() { }

	public int get_IndexOfFirst() { }

	public int get_IndexOfLast() { }

	public override TValue get_Item(TKey key) { }

	public IEqualityComparer<TKey> get_KeyComparer() { }

	public KeyCollection<TKey, TValue> get_Keys() { }

	public int get_TotalCount() { }

	public IEqualityComparer<TValue> get_ValueComparer() { }

	public ValueCollection<TKey, TValue> get_Values() { }

	public KeyValuePair<TKey, TValue> GetEntryAt(int index) { }

	public Enumerator<TKey, TValue> GetEnumerator() { }

	public TKey GetKeyAt(int index) { }

	public bool GetNextEntry(ref int index, out KeyValuePair<TKey, TValue>& entry) { }

	public bool GetNextIndex(ref int index) { }

	public int GetNextIndex(int index) { }

	public bool GetNextKey(ref int index, out TKey key) { }

	public bool GetNextValue(ref int index, out TValue value) { }

	public bool GetPreviousEntry(ref int index, out KeyValuePair<TKey, TValue>& entry) { }

	public int GetPreviousIndex(int index) { }

	public bool GetPreviousIndex(ref int index) { }

	public bool GetPreviousKey(ref int index, out TKey key) { }

	public bool GetPreviousValue(ref int index, out TValue value) { }

	public TValue GetValueAt(int index) { }

	public TValue GetValueSafe(TKey key) { }

	private static void hyKDklGMPqUmmXOBqApxdvluyOBiA(object unnamed_param_0, string unnamed_param_1) { }

	public int IndexOfKey(TKey key) { }

	public int IndexOfValue(TValue value) { }

	public bool IsValidAt(int index) { }

	private void IWFXpphTaVQrEpkwWvlAttuMMfpW(TKey unnamed_param_0, TValue unnamed_param_1, bool unnamed_param_2) { }

	public override bool Remove(TKey key) { }

	public bool RemoveAt(int index) { }

	public override void set_Item(TKey key, TValue value) { }

	public void set_KeyComparer(IEqualityComparer<TKey> value) { }

	public void set_ValueComparer(IEqualityComparer<TValue> value) { }

	private void sWQRHFxynRkyvmtVvIFuoCcvcQMgA() { }

	private void sWQRHFxynRkyvmtVvIFuoCcvcQMgA(int unnamed_param_0, bool unnamed_param_1) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> unnamed_param_0) { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> unnamed_param_0) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] unnamed_param_0, int unnamed_param_1) { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> unnamed_param_0) { }

	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	private override IEnumerator<KeyValuePair`2<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

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

	private static bool tpeFaIqOAyHPJXeubaUvWyJkPXFF(object unnamed_param_0) { }

	public bool TryGetEntryAt(int index, out KeyValuePair<TKey, TValue>& entry) { }

	public bool TryGetKeyAt(int index, out TKey key) { }

	public override bool TryGetValue(TKey key, out TValue value) { }

	public bool TryGetValueAt(int index, out TValue value) { }

}

