namespace System.Collections;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable
{
	private ArrayList list; //Field offset: 0x10

	public override int Count
	{
		 get { } //Length: 139
	}

	protected ArrayList InnerList
	{
		 get { } //Length: 106
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 139
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 139
	}

	protected ReadOnlyCollectionBase() { }

	public override int get_Count() { }

	protected ArrayList get_InnerList() { }

	public override IEnumerator GetEnumerator() { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

}

