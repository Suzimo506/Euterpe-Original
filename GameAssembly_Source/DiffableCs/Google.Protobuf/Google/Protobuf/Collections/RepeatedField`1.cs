namespace Google.Protobuf.Collections;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class RepeatedField : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IDeepCloneable<RepeatedField`1<T>>, IEquatable<RepeatedField`1<T>>, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__28 : IEnumerator<T>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		public RepeatedField<T> <>4__this; //Field offset: 0x0
		private int <i>5__2; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 63
		}

		[DebuggerHidden]
		public <GetEnumerator>d__28(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static readonly EqualityComparer<T> EqualityComparer; //Field offset: 0x0
	private static readonly T[] EmptyArray; //Field offset: 0x0
	private T[] array; //Field offset: 0x0
	private int count; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 4
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public override T Item
	{
		 get { } //Length: 151
		 set { } //Length: 209
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 4
	}

	private override bool System.Collections.IList.IsFixedSize
	{
		private get { } //Length: 3
	}

	private override object System.Collections.IList.Item
	{
		private get { } //Length: 100
		private set { } //Length: 177
	}

	private static RepeatedField`1() { }

	public RepeatedField`1() { }

	public void Add(IEnumerable<T> values) { }

	public override void Add(T item) { }

	public void AddEntriesFrom(ref ParseContext ctx, FieldCodec<T> codec) { }

	public void AddRange(IEnumerable<T> values) { }

	private int CalculatePackedDataSize(FieldCodec<T> codec) { }

	public int CalculateSize(FieldCodec<T> codec) { }

	public override void Clear() { }

	public override RepeatedField<T> Clone() { }

	public override bool Contains(T item) { }

	public override void CopyTo(T[] array, int arrayIndex) { }

	private void EnsureSize(int size) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(RepeatedField<T> other) { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public override T get_Item(int index) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override IEnumerator<T> GetEnumerator() { }

	public virtual int GetHashCode() { }

	public override int IndexOf(T item) { }

	public override void Insert(int index, T item) { }

	public override bool Remove(T item) { }

	public override void RemoveAt(int index) { }

	public override void set_Item(int index, T value) { }

	private void SetSize(int size) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override int System.Collections.IList.Add(object value) { }

	private override bool System.Collections.IList.Contains(object value) { }

	private override bool System.Collections.IList.get_IsFixedSize() { }

	private override object System.Collections.IList.get_Item(int index) { }

	private override int System.Collections.IList.IndexOf(object value) { }

	private override void System.Collections.IList.Insert(int index, object value) { }

	private override void System.Collections.IList.Remove(object value) { }

	private override void System.Collections.IList.set_Item(int index, object value) { }

	public virtual string ToString() { }

	public void WriteTo(ref WriteContext ctx, FieldCodec<T> codec) { }

}

