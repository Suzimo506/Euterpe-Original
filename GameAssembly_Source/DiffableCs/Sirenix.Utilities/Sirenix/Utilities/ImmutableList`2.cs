namespace Sirenix.Utilities;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class ImmutableList : IImmutableList<TElement>, IImmutableList, IList, IEnumerable, ICollection, IList<TElement>, ICollection<TElement>, IEnumerable<TElement>
{
	private TList innerList; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 84
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public override TElement Item
	{
		 get { } //Length: 101
	}

	private override TElement System.Collections.Generic.IList<TElement>.Item
	{
		private get { } //Length: 101
		private set { } //Length: 81
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 3
	}

	private override bool System.Collections.IList.IsFixedSize
	{
		private get { } //Length: 3
	}

	private override bool System.Collections.IList.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override object System.Collections.IList.Item
	{
		private get { } //Length: 39
		private set { } //Length: 81
	}

	public ImmutableList`2(TList innerList) { }

	public override bool Contains(TElement item) { }

	public override void CopyTo(TElement[] array, int arrayIndex) { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public override TElement get_Item(int index) { }

	public override IEnumerator<TElement> GetEnumerator() { }

	public override int IndexOf(TElement item) { }

	private override void System.Collections.Generic.ICollection<TElement>.Add(TElement item) { }

	private override void System.Collections.Generic.ICollection<TElement>.Clear() { }

	private override bool System.Collections.Generic.ICollection<TElement>.Remove(TElement item) { }

	private override TElement System.Collections.Generic.IList<TElement>.get_Item(int index) { }

	private override void System.Collections.Generic.IList<TElement>.Insert(int index, TElement item) { }

	private override void System.Collections.Generic.IList<TElement>.RemoveAt(int index) { }

	private override void System.Collections.Generic.IList<TElement>.set_Item(int index, TElement value) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override int System.Collections.IList.Add(object value) { }

	private override void System.Collections.IList.Clear() { }

	private override bool System.Collections.IList.Contains(object value) { }

	private override bool System.Collections.IList.get_IsFixedSize() { }

	private override bool System.Collections.IList.get_IsReadOnly() { }

	private override object System.Collections.IList.get_Item(int index) { }

	private override int System.Collections.IList.IndexOf(object value) { }

	private override void System.Collections.IList.Insert(int index, object value) { }

	private override void System.Collections.IList.Remove(object value) { }

	private override void System.Collections.IList.RemoveAt(int index) { }

	private override void System.Collections.IList.set_Item(int index, object value) { }

}

