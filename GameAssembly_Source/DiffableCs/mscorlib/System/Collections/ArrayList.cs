namespace System.Collections;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DebuggerTypeProxy(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ArrayList : IList, ICollection, IEnumerable, ICloneable
{
	public class ArrayListDebugView
	{
		private ArrayList arrayList; //Field offset: 0x10

		[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public Object[] Items
		{
			 get { } //Length: 39
		}

		public ArrayListDebugView(ArrayList arrayList) { }

		public Object[] get_Items() { }

	}

	private sealed class ArrayListEnumeratorSimple : IEnumerator, ICloneable
	{
		private static object dummyObject; //Field offset: 0x0
		private ArrayList list; //Field offset: 0x10
		private int index; //Field offset: 0x18
		private int version; //Field offset: 0x1C
		private object currentElement; //Field offset: 0x20
		private bool isArrayList; //Field offset: 0x28

		public override object Current
		{
			 get { } //Length: 234
		}

		private static ArrayListEnumeratorSimple() { }

		internal ArrayListEnumeratorSimple(ArrayList list) { }

		public override object Clone() { }

		public override object get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private class IListWrapper : ArrayList
	{
		private IList _list; //Field offset: 0x28

		public virtual int Capacity
		{
			 set { } //Length: 144
		}

		public virtual int Count
		{
			 get { } //Length: 72
		}

		public virtual bool IsFixedSize
		{
			 get { } //Length: 72
		}

		public virtual bool IsReadOnly
		{
			 get { } //Length: 72
		}

		public virtual bool IsSynchronized
		{
			 get { } //Length: 72
		}

		public virtual object Item
		{
			 get { } //Length: 83
			 set { } //Length: 108
		}

		public virtual object SyncRoot
		{
			 get { } //Length: 72
		}

		internal IListWrapper(IList list) { }

		public virtual int Add(object obj) { }

		public virtual void AddRange(ICollection c) { }

		public virtual void Clear() { }

		public virtual object Clone() { }

		public virtual bool Contains(object obj) { }

		public virtual void CopyTo(int index, Array array, int arrayIndex, int count) { }

		public virtual void CopyTo(Array array, int index) { }

		public virtual int get_Count() { }

		public virtual bool get_IsFixedSize() { }

		public virtual bool get_IsReadOnly() { }

		public virtual bool get_IsSynchronized() { }

		public virtual object get_Item(int index) { }

		public virtual object get_SyncRoot() { }

		public virtual IEnumerator GetEnumerator() { }

		public virtual int IndexOf(object value) { }

		public virtual void Insert(int index, object obj) { }

		public virtual void InsertRange(int index, ICollection c) { }

		public virtual void Remove(object value) { }

		public virtual void RemoveAt(int index) { }

		public virtual void RemoveRange(int index, int count) { }

		public virtual void set_Capacity(int value) { }

		public virtual void set_Item(int index, object value) { }

		public virtual void Sort(int index, int count, IComparer comparer) { }

		public virtual Object[] ToArray() { }

		public virtual Array ToArray(Type type) { }

	}

	[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private class ReadOnlyArrayList : ArrayList
	{
		private ArrayList _list; //Field offset: 0x28

		public virtual int Capacity
		{
			 set { } //Length: 98
		}

		public virtual int Count
		{
			 get { } //Length: 39
		}

		public virtual bool IsFixedSize
		{
			 get { } //Length: 3
		}

		public virtual bool IsReadOnly
		{
			 get { } //Length: 3
		}

		public virtual bool IsSynchronized
		{
			 get { } //Length: 39
		}

		public virtual object Item
		{
			 get { } //Length: 39
			 set { } //Length: 98
		}

		public virtual object SyncRoot
		{
			 get { } //Length: 39
		}

		internal ReadOnlyArrayList(ArrayList l) { }

		public virtual int Add(object obj) { }

		public virtual void AddRange(ICollection c) { }

		public virtual void Clear() { }

		public virtual object Clone() { }

		public virtual bool Contains(object obj) { }

		public virtual void CopyTo(int index, Array array, int arrayIndex, int count) { }

		public virtual void CopyTo(Array array, int index) { }

		public virtual int get_Count() { }

		public virtual bool get_IsFixedSize() { }

		public virtual bool get_IsReadOnly() { }

		public virtual bool get_IsSynchronized() { }

		public virtual object get_Item(int index) { }

		public virtual object get_SyncRoot() { }

		public virtual IEnumerator GetEnumerator() { }

		public virtual int IndexOf(object value) { }

		public virtual void Insert(int index, object obj) { }

		public virtual void InsertRange(int index, ICollection c) { }

		public virtual void Remove(object value) { }

		public virtual void RemoveAt(int index) { }

		public virtual void RemoveRange(int index, int count) { }

		public virtual void set_Capacity(int value) { }

		public virtual void set_Item(int index, object value) { }

		public virtual void Sort(int index, int count, IComparer comparer) { }

		public virtual Object[] ToArray() { }

		public virtual Array ToArray(Type type) { }

	}

	[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private class ReadOnlyList : IList, ICollection, IEnumerable
	{
		private IList _list; //Field offset: 0x10

		public override int Count
		{
			 get { } //Length: 72
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
			 get { } //Length: 72
		}

		public override object Item
		{
			 get { } //Length: 83
			 set { } //Length: 98
		}

		public override object SyncRoot
		{
			 get { } //Length: 72
		}

		internal ReadOnlyList(IList l) { }

		public override int Add(object obj) { }

		public override void Clear() { }

		public override bool Contains(object obj) { }

		public override void CopyTo(Array array, int index) { }

		public override int get_Count() { }

		public override bool get_IsFixedSize() { }

		public override bool get_IsReadOnly() { }

		public override bool get_IsSynchronized() { }

		public override object get_Item(int index) { }

		public override object get_SyncRoot() { }

		public override IEnumerator GetEnumerator() { }

		public override int IndexOf(object value) { }

		public override void Insert(int index, object obj) { }

		public override void Remove(object value) { }

		public override void RemoveAt(int index) { }

		public override void set_Item(int index, object value) { }

	}

	private const int _defaultCapacity = 4; //Field offset: 0x0
	private static readonly Object[] emptyArray; //Field offset: 0x0
	private Object[] _items; //Field offset: 0x10
	private int _size; //Field offset: 0x18
	private int _version; //Field offset: 0x1C
	private object _syncRoot; //Field offset: 0x20

	public override int Capacity
	{
		 set { } //Length: 253
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
		 get { } //Length: 172
		 set { } //Length: 261
	}

	public override object SyncRoot
	{
		 get { } //Length: 105
	}

	private static ArrayList() { }

	public ArrayList(ICollection c) { }

	public ArrayList() { }

	public ArrayList(int capacity) { }

	public static ArrayList Adapter(IList list) { }

	public override int Add(object value) { }

	public override void AddRange(ICollection c) { }

	public override void Clear() { }

	public override object Clone() { }

	public override bool Contains(object item) { }

	public override void CopyTo(Array array, int arrayIndex) { }

	public override void CopyTo(int index, Array array, int arrayIndex, int count) { }

	public override void CopyTo(Array array) { }

	private void EnsureCapacity(int min) { }

	public override int get_Count() { }

	public override bool get_IsFixedSize() { }

	public override bool get_IsReadOnly() { }

	public override bool get_IsSynchronized() { }

	public override object get_Item(int index) { }

	public override object get_SyncRoot() { }

	public override IEnumerator GetEnumerator() { }

	public override int IndexOf(object value) { }

	public override void Insert(int index, object value) { }

	public override void InsertRange(int index, ICollection c) { }

	public static IList ReadOnly(IList list) { }

	public static ArrayList ReadOnly(ArrayList list) { }

	public override void Remove(object obj) { }

	public override void RemoveAt(int index) { }

	public override void RemoveRange(int index, int count) { }

	public override void set_Capacity(int value) { }

	public override void set_Item(int index, object value) { }

	public override void Sort(IComparer comparer) { }

	public override void Sort(int index, int count, IComparer comparer) { }

	public override Object[] ToArray() { }

	public override Array ToArray(Type type) { }

}

