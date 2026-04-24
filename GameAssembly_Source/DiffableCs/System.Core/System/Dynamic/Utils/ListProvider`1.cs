namespace System.Dynamic.Utils;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal abstract class ListProvider : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__20 : IEnumerator<T>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		public ListProvider<T> <>4__this; //Field offset: 0x0
		private int <i>5__1; //Field offset: 0x0
		private int <n>5__2; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetEnumerator>d__20(int <>1__state) { }

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


	public override int Count
	{
		 get { } //Length: 35
	}

	protected abstract int ElementCount
	{
		 get { } //Length: 0
	}

	protected abstract T First
	{
		 get { } //Length: 0
	}

	[ExcludeFromCodeCoverage]
	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public override T Item
	{
		 get { } //Length: 57
		[ExcludeFromCodeCoverage]
		 set { } //Length: 53
	}

	protected ListProvider`1() { }

	[ExcludeFromCodeCoverage]
	public override void Add(T item) { }

	[ExcludeFromCodeCoverage]
	public override void Clear() { }

	public override bool Contains(T item) { }

	public override void CopyTo(T[] array, int index) { }

	public override int get_Count() { }

	protected abstract int get_ElementCount() { }

	protected abstract T get_First() { }

	public override bool get_IsReadOnly() { }

	public override T get_Item(int index) { }

	protected abstract T GetElement(int index) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override IEnumerator<T> GetEnumerator() { }

	public override int IndexOf(T item) { }

	[ExcludeFromCodeCoverage]
	public override void Insert(int index, T item) { }

	[ExcludeFromCodeCoverage]
	public override bool Remove(T item) { }

	[ExcludeFromCodeCoverage]
	public override void RemoveAt(int index) { }

	[ExcludeFromCodeCoverage]
	public override void set_Item(int index, T value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

