namespace UnityEngine.UI.Collections;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class IndexedSet : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	private readonly List<T> m_List; //Field offset: 0x0
	private Dictionary<T, Int32> m_Dictionary; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 43
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public override T Item
	{
		 get { } //Length: 43
		 set { } //Length: 207
	}

	public IndexedSet`1() { }

	public override void Add(T item) { }

	public bool AddUnique(T item) { }

	public override void Clear() { }

	public override bool Contains(T item) { }

	public override void CopyTo(T[] array, int arrayIndex) { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public override T get_Item(int index) { }

	public override IEnumerator<T> GetEnumerator() { }

	public override int IndexOf(T item) { }

	public override void Insert(int index, T item) { }

	public override bool Remove(T item) { }

	public void RemoveAll(Predicate<T> match) { }

	public override void RemoveAt(int index) { }

	public override void set_Item(int index, T value) { }

	public void Sort(Comparison<T> sortLayoutFunction) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

