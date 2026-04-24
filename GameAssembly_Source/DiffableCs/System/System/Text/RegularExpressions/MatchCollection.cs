namespace System.Text.RegularExpressions;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class MatchCollection : ICollection, IEnumerable
{
	private static int infinite; //Field offset: 0x0
	internal Regex _regex; //Field offset: 0x10
	internal ArrayList _matches; //Field offset: 0x18
	internal bool _done; //Field offset: 0x20
	internal string _input; //Field offset: 0x28
	internal int _beginning; //Field offset: 0x30
	internal int _length; //Field offset: 0x34
	internal int _startat; //Field offset: 0x38
	internal int _prevlen; //Field offset: 0x3C

	public override int Count
	{
		 get { } //Length: 138
	}

	public override bool IsSynchronized
	{
		 get { } //Length: 3
	}

	public override Match Item
	{
		 get { } //Length: 119
	}

	public override object SyncRoot
	{
		 get { } //Length: 4
	}

	private static MatchCollection() { }

	internal MatchCollection(Regex regex, string input, int beginning, int length, int startat) { }

	internal MatchCollection() { }

	public override void CopyTo(Array array, int arrayIndex) { }

	public override int get_Count() { }

	public override bool get_IsSynchronized() { }

	public override Match get_Item(int i) { }

	public override object get_SyncRoot() { }

	public override IEnumerator GetEnumerator() { }

	internal Match GetMatch(int i) { }

}

