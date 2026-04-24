namespace Sirenix.Serialization.Utilities;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal sealed class ImmutableList : IImmutableList<Object>, IImmutableList, IList, IEnumerable, ICollection, IList<Object>, ICollection<Object>, IEnumerable<Object>
{
	[CompilerGenerated]
	private sealed class <System-Collections-Generic-IEnumerable<System-Object>-GetEnumerator>d__25 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ImmutableList <>4__this; //Field offset: 0x20
		private IEnumerator <>7__wrap1; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
		public <System-Collections-Generic-IEnumerable<System-Object>-GetEnumerator>d__25(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[SerializeField]
	private IList innerList; //Field offset: 0x10

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
	}

	public override object SyncRoot
	{
		 get { } //Length: 72
	}

	private override object System.Collections.Generic.IList<System.Object>.Item
	{
		private get { } //Length: 83
		private set { } //Length: 81
	}

	private override object System.Collections.IList.Item
	{
		private get { } //Length: 83
		private set { } //Length: 81
	}

	public ImmutableList(IList innerList) { }

	public override bool Contains(object value) { }

	public override void CopyTo(Object[] array, int arrayIndex) { }

	public override void CopyTo(Array array, int index) { }

	public override int get_Count() { }

	public override bool get_IsFixedSize() { }

	public override bool get_IsReadOnly() { }

	public override bool get_IsSynchronized() { }

	public override object get_Item(int index) { }

	public override object get_SyncRoot() { }

	public IEnumerator GetEnumerator() { }

	public override int IndexOf(object value) { }

	private override void System.Collections.Generic.ICollection<System.Object>.Add(object item) { }

	private override void System.Collections.Generic.ICollection<System.Object>.Clear() { }

	private override bool System.Collections.Generic.ICollection<System.Object>.Remove(object item) { }

	private override IEnumerator<Object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator() { }

	private override object System.Collections.Generic.IList<System.Object>.get_Item(int index) { }

	private override void System.Collections.Generic.IList<System.Object>.Insert(int index, object item) { }

	private override void System.Collections.Generic.IList<System.Object>.RemoveAt(int index) { }

	private override void System.Collections.Generic.IList<System.Object>.set_Item(int index, object value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override int System.Collections.IList.Add(object value) { }

	private override void System.Collections.IList.Clear() { }

	private override object System.Collections.IList.get_Item(int index) { }

	private override void System.Collections.IList.Insert(int index, object value) { }

	private override void System.Collections.IList.Remove(object value) { }

	private override void System.Collections.IList.RemoveAt(int index) { }

	private override void System.Collections.IList.set_Item(int index, object value) { }

}

