namespace System.Net;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class PathList
{
	private class PathListComparer : IComparer
	{
		internal static readonly PathListComparer StaticInstance; //Field offset: 0x6A8F0

		private static PathListComparer() { }

		public PathListComparer() { }

		private override int System.Collections.IComparer.Compare(object ol, object or) { }

	}

	private SortedList m_list; //Field offset: 0x10

	public int Count
	{
		 get { } //Length: 39
	}

	public object Item
	{
		 get { } //Length: 39
		 set { } //Length: 217
	}

	public object SyncRoot
	{
		 get { } //Length: 39
	}

	public ICollection Values
	{
		 get { } //Length: 39
	}

	public PathList() { }

	public int get_Count() { }

	public object get_Item(string s) { }

	public object get_SyncRoot() { }

	public ICollection get_Values() { }

	public int GetCookiesCount() { }

	public IEnumerator GetEnumerator() { }

	public void set_Item(string s, object value) { }

}

