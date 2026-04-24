namespace System.Text.RegularExpressions;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class GroupCollection : ICollection, IEnumerable
{
	internal Match _match; //Field offset: 0x10
	internal Hashtable _captureMap; //Field offset: 0x18
	internal Group[] _groups; //Field offset: 0x20

	public override int Count
	{
		 get { } //Length: 35
	}

	public override bool IsSynchronized
	{
		 get { } //Length: 3
	}

	public Group Item
	{
		 get { } //Length: 312
	}

	public override object SyncRoot
	{
		 get { } //Length: 5
	}

	internal GroupCollection(Match match, Hashtable caps) { }

	internal GroupCollection() { }

	public override void CopyTo(Array array, int arrayIndex) { }

	public override int get_Count() { }

	public override bool get_IsSynchronized() { }

	public Group get_Item(int groupnum) { }

	public override object get_SyncRoot() { }

	public override IEnumerator GetEnumerator() { }

	internal Group GetGroup(int groupnum) { }

	internal Group GetGroupImpl(int groupnum) { }

}

