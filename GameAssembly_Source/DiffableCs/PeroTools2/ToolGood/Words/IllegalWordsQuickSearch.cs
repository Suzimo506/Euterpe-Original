namespace ToolGood.Words;

public class IllegalWordsQuickSearch : IllegalWordsSearch
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public bool r; //Field offset: 0x10
		public IllegalWordsQuickSearch <>4__this; //Field offset: 0x18
		public string text; //Field offset: 0x20
		public string searchText; //Field offset: 0x28

		public <>c__DisplayClass1_0() { }

		internal bool <ContainsAny>b__0(string keyword, char ch, int end) { }

		internal bool <ContainsAny>b__1(string keyword, char ch, int end) { }

		internal bool <ContainsAny>b__2(string keyword, char ch, int end) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public IllegalWordsSearchResult result; //Field offset: 0x10
		public IllegalWordsQuickSearch <>4__this; //Field offset: 0x18
		public string text; //Field offset: 0x20
		public string searchText; //Field offset: 0x28

		public <>c__DisplayClass2_0() { }

		internal bool <FindFirst>b__0(string keyword, char ch, int end) { }

		internal bool <FindFirst>b__1(string keyword, char ch, int end) { }

		internal bool <FindFirst>b__2(string keyword, char ch, int end) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public IllegalWordsQuickSearch <>4__this; //Field offset: 0x10
		public string text; //Field offset: 0x18
		public string searchText; //Field offset: 0x20
		public List<IllegalWordsSearchResult> newlist; //Field offset: 0x28

		public <>c__DisplayClass3_0() { }

		internal void <FindAll>b__0(string keyword, char ch, int end) { }

		internal void <FindAll>b__1(string keyword, char ch, int end) { }

	}


	public IllegalWordsQuickSearch(int jumpLength = 1) { }

	public virtual bool ContainsAny(string text) { }

	public virtual List<IllegalWordsSearchResult> FindAll(string text) { }

	public virtual IllegalWordsSearchResult FindFirst(string text) { }

	private IllegalWordsSearchResult GetIllegalResult(string keyword, char ch, int start, int end, string srcText, string searchText) { }

	private string removeChecks(string text, List<IllegalWordsSearchResult> results) { }

	private void search(string text, Func<String, Char, Int32, Boolean> func) { }

	private void searchAll(string text, Action<String, Char, Int32> action) { }

}

