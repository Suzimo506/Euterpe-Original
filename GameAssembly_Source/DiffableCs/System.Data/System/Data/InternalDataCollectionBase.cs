namespace System.Data;

public class InternalDataCollectionBase : ICollection, IEnumerable
{
	internal static readonly CollectionChangeEventArgs s_refreshEventArgs; //Field offset: 0x6B5E0

	[Browsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override int Count
	{
		 get { } //Length: 54
	}

	[Browsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override bool IsSynchronized
	{
		 get { } //Length: 3
	}

	protected override ArrayList List
	{
		 get { } //Length: 3
	}

	[Browsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override object SyncRoot
	{
		 get { } //Length: 4
	}

	private static InternalDataCollectionBase() { }

	public InternalDataCollectionBase() { }

	public override void CopyTo(Array ar, int index) { }

	public override int get_Count() { }

	public override bool get_IsSynchronized() { }

	protected override ArrayList get_List() { }

	public override object get_SyncRoot() { }

	public override IEnumerator GetEnumerator() { }

	internal int NamesEqual(string s1, string s2, bool fCaseSensitive, CultureInfo locale) { }

}

