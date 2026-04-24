namespace Rewired.Utils.Classes.Data;

[CustomClassObfuscation]
[CustomObfuscation]
[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class AList : IList, IEnumerable, IEnumerable<T>, ICollection, ICollection<T>, IList<T>
{
	internal struct MlvUqJRzuOKdfMCRyrwySRcBPFvE : IDisposable, IEnumerator, IEnumerator<>
	{
		private AList<> list; //Field offset: 0x0
		private int index; //Field offset: 0x0
		private int version; //Field offset: 0x0
		private  current; //Field offset: 0x0

		public override  Current
		{
			 get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 234
		}

		internal MlvUqJRzuOKdfMCRyrwySRcBPFvE(AList<> unnamed_param_0) { }

		public override void Dispose() { }

		public override  get_Current() { }

		public override bool MoveNext() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

		private bool WaPswJerijpjNNfKccDDgkFnuRi() { }

	}

	private const int iKJyRwgRJgSEAtHIcVdazUWXGNdU = 4; //Field offset: 0x0
	private static readonly T[] sOVIFCJhyrpKoyUucfXbyhOWMIUB; //Field offset: 0x0
	private IEqualityComparer<T> hoHDrxdzKrmDOFcCcYazKFDZackZA; //Field offset: 0x0
	public T[] _items; //Field offset: 0x0
	private int fHFzqBypypzEdxCsGjiRCvUHhtXo; //Field offset: 0x0
	public int _count; //Field offset: 0x0
	private int fHbGZpnBgVOSEOQBrlEznbkjKAMW; //Field offset: 0x0
	private bool qQKHPnHcCSFHReJLZdKHChznmPexA; //Field offset: 0x0
	private readonly int cKtbYaNSykLGnlSMrhyUdLuUrtfM; //Field offset: 0x0
	private readonly bool YmzCWEdjHXxmYqeATDgHPYJIhUTD; //Field offset: 0x0
	private int GusbjnNWxeqFGJLFxSjFjcDCeenJ; //Field offset: 0x0
	private object JvTepDFBJnRKFvFEmZXdJPiGYFyJA; //Field offset: 0x0

	public int Capacity
	{
		 get { } //Length: 4
	}

	public override int Count
	{
		 get { } //Length: 4
	}

	public IEqualityComparer<T> EqualityComparer
	{
		 get { } //Length: 5
		 set { } //Length: 56
	}

	public int FreeSpace
	{
		 get { } //Length: 7
	}

	public override bool IsFixedSize
	{
		 get { } //Length: 8
	}

	public override T Item
	{
		 get { } //Length: 140
		 set { } //Length: 170
	}

	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override int System.Collections.ICollection.Count
	{
		private get { } //Length: 4
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 105
	}

	private override bool System.Collections.IList.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override object System.Collections.IList.Item
	{
		private get { } //Length: 115
		private set { } //Length: 427
	}

	public int Version
	{
		 get { } //Length: 4
	}

	private static AList`1() { }

	public AList`1(IEnumerable<T> unnamed_param_0, int unnamed_param_1, int unnamed_param_2) { }

	public AList`1(IEnumerable<T> unnamed_param_0) { }

	public AList`1(int unnamed_param_0, int unnamed_param_1, int unnamed_param_2) { }

	public AList`1(int unnamed_param_0, int unnamed_param_1) { }

	public AList`1() { }

	public AList`1(int unnamed_param_0) { }

	public int Add(T item) { }

	public bool Add(T[] items, int count = 0, int startIndex = 0, bool allowPartialAdd = false) { }

	public bool Add(AList<T> items, int count = 0, int startIndex = 0, bool allowPartialAdd = false) { }

	public int AddIfUnique(T item) { }

	public int AddToFirstOpenSpace(T item) { }

	public int AddToFirstOpenSpace(T item, T openSpaceEquals) { }

	public ReadOnlyCollection<T> AsReadOnly() { }

	public override void Clear() { }

	public bool Contains(T item, IEqualityComparer<T> comparer) { }

	public override bool Contains(T item) { }

	public void CopyTo(int index, T[] array, int arrayIndex, int count) { }

	public void CopyTo(T[] array, int arrayIndex) { }

	public static AList<T> CreateFixedLengthList(int capacity) { }

	public bool Exists(Predicate<T> match) { }

	public T Find(Predicate<T> match) { }

	public List<T> FindAll(Predicate<T> match) { }

	public int FindIndex(int startIndex, int count, Predicate<T> match) { }

	public int FindIndex(int startIndex, Predicate<T> match) { }

	public int FindIndex(Predicate<T> match) { }

	public T FindLast(Predicate<T> match) { }

	public int FindLastIndex(int startIndex, Predicate<T> match) { }

	public int FindLastIndex(int startIndex, int count, Predicate<T> match) { }

	public int FindLastIndex(Predicate<T> match) { }

	public void ForEach(Action<T> action) { }

	public int get_Capacity() { }

	public override int get_Count() { }

	public IEqualityComparer<T> get_EqualityComparer() { }

	public int get_FreeSpace() { }

	public override bool get_IsFixedSize() { }

	public override T get_Item(int index) { }

	public int get_Version() { }

	public T GetRandom() { }

	public List<T> GetRange(int index, int count) { }

	public int IndexOf(T item, int index, IEqualityComparer<T> comparer) { }

	public int IndexOf(T item, IEqualityComparer<T> comparer) { }

	public int IndexOf(T item, int index, int count) { }

	public int IndexOf(T item, int index) { }

	public override int IndexOf(T item) { }

	public int IndexOf(T item, int index, int count, IEqualityComparer<T> comparer) { }

	public bool Insert(int index, T item) { }

	public int LastIndexOf(T item, int index) { }

	public int LastIndexOf(T item) { }

	public int LastIndexOf(T item, int index, int count) { }

	private int mORNQPMokMTwYYMSMeXrwBaUXRg(int unnamed_param_0, bool unnamed_param_1 = false) { }

	private int oTZaeODmGWwkcAXntAmXnUborfZd(int unnamed_param_0, int unnamed_param_1) { }

	public override bool Remove(T item) { }

	public int RemoveAll(Predicate<T> match) { }

	public override void RemoveAt(int index) { }

	public void Reverse() { }

	public void Reverse(int index, int count) { }

	public void set_EqualityComparer(IEqualityComparer<T> value) { }

	public override void set_Item(int index, T value) { }

	public void Sort(int index, int count, IComparer<T> comparer) { }

	public void Sort() { }

	public void Sort(IComparer<T> comparer) { }

	private bool sWQRHFxynRkyvmtVvIFuoCcvcQMgA(int unnamed_param_0, bool unnamed_param_1 = false) { }

	private override void System.Collections.Generic.ICollection<T>.Add(T unnamed_param_0) { }

	private override void System.Collections.Generic.ICollection<T>.CopyTo(T[] unnamed_param_0, int unnamed_param_1) { }

	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override void System.Collections.Generic.IList<T>.Insert(int unnamed_param_0, T unnamed_param_1) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override int System.Collections.ICollection.get_Count() { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override int System.Collections.IList.Add(object value) { }

	private override bool System.Collections.IList.Contains(object value) { }

	private override bool System.Collections.IList.get_IsReadOnly() { }

	private override object System.Collections.IList.get_Item(int index) { }

	private override int System.Collections.IList.IndexOf(object value) { }

	private override void System.Collections.IList.Insert(int index, object value) { }

	private override void System.Collections.IList.Remove(object value) { }

	private override void System.Collections.IList.set_Item(int index, object value) { }

	public T[] ToArray() { }

	public void TrimExcess() { }

	public bool TrueForAll(Predicate<T> match) { }

	private static bool WQbWECKSnvadMkrWGmZLBxZnMnvib(object unnamed_param_0) { }

}

