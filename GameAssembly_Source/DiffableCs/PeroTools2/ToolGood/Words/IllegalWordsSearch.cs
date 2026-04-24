namespace ToolGood.Words;

public class IllegalWordsSearch : BaseSearch
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<IllegalWordsSearchResult, Int32> <>9__8_0; //Field offset: 0x8
		public static Func<IllegalWordsSearchResult, Int32> <>9__8_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <Replace>b__8_0(IllegalWordsSearchResult q) { }

		internal int <Replace>b__8_1(IllegalWordsSearchResult q) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public IllegalWordsSearchResult r; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		internal bool <FindAll>b__0(IllegalWordsSearchResult q) { }

	}

	private class NodeInfo
	{
		public int Index; //Field offset: 0x10
		public bool End; //Field offset: 0x14
		public NodeInfo Parent; //Field offset: 0x18
		public TrieNode Node; //Field offset: 0x20
		public char Type; //Field offset: 0x28

		public NodeInfo(int index, char c, TrieNode node, NodeInfo parent = null) { }

		public bool CanJump(char c, int index, int jump) { }

		public bool TryGetValue(char c, out TrieNode node) { }

	}

	private class SearchHelper : IDisposable
	{
		private NodeInfo mainNode; //Field offset: 0x10
		private List<NodeInfo> nodes; //Field offset: 0x18
		private TrieNode[] _first; //Field offset: 0x20
		private int _jumpLength; //Field offset: 0x28

		public SearchHelper(ref TrieNode[] first, int jumpLength) { }

		public override void Dispose() { }

		public bool FindChar(char c, int index) { }

		public List<ThreeEntity`3<Int32, Int32, String>> GetKeywords() { }

	}

	private class ThreeEntity
	{
		public T1 t1; //Field offset: 0x0
		public T2 t2; //Field offset: 0x0
		public T3 t3; //Field offset: 0x0

		public ThreeEntity`3() { }

	}

	protected const string bitType = "00000000000000000000000000000000000000000000000011111111110000000aaaaaaaaaaaaaaaaaaaaaaaaaa000000aaaaaaaaaaaaaaaaaaaaaaaaaa00000"; //Field offset: 0x0
	protected int _jumpLength; //Field offset: 0x20

	public IllegalWordsSearch(int jumpLength = 1) { }

	public override bool ContainsAny(string text) { }

	public override List<IllegalWordsSearchResult> FindAll(string text) { }

	public override IllegalWordsSearchResult FindFirst(string text) { }

	private IllegalWordsSearchResult GetIllegalResult(string keyword, char ch, int start, int end, string srcText, StringBuilder searchText) { }

	protected bool isInEnglishOrInNumber(string keyword, char ch, int end, string searchText) { }

	public override string Replace(string text, char replaceChar = *) { }

	public virtual void SetKeywords(ICollection<String> keywords) { }

	private bool ToSenseWords(char c, out char w) { }

}

