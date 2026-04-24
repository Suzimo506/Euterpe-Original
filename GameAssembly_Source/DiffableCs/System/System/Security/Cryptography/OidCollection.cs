namespace System.Security.Cryptography;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class OidCollection : ICollection, IEnumerable
{
	private ArrayList m_list; //Field offset: 0x10

	public override int Count
	{
		 get { } //Length: 39
	}

	public override bool IsSynchronized
	{
		 get { } //Length: 3
	}

	public Oid Item
	{
		 get { } //Length: 120
	}

	public override object SyncRoot
	{
		 get { } //Length: 4
	}

	public OidCollection() { }

	public int Add(Oid oid) { }

	public override int get_Count() { }

	public override bool get_IsSynchronized() { }

	public Oid get_Item(int index) { }

	public override object get_SyncRoot() { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

