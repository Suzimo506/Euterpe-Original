namespace ToolGood.Words;

public class PinYinSearch
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int32, Int32> <>9__14_0; //Field offset: 0x8
		public static Func<Int32, Int32> <>9__15_0; //Field offset: 0x10
		public static Func<Int32, Int32> <>9__16_0; //Field offset: 0x18
		public static Func<Int32, Int32> <>9__17_0; //Field offset: 0x20
		public static Func<Int32, Int32> <>9__18_0; //Field offset: 0x28
		public static Func<String, String> <>9__25_0; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal int <PickTexts>b__17_0(int q) { }

		internal int <PickTextWithIds>b__18_0(int q) { }

		internal int <SearchIds>b__15_0(int q) { }

		internal int <SearchTexts>b__14_0(int q) { }

		internal int <SearchTextWithIds>b__16_0(int q) { }

		internal string <SplitKeywords>b__25_0(string q) { }

	}

	private class ChineseNode
	{
		private Dictionary<Char, FirstPinYinNode> FirstPinYinNodes; //Field offset: 0x10
		public int RangeStart; //Field offset: 0x18
		public int RangeEnd; //Field offset: 0x1C

		public ChineseNode() { }

		public ChineseNode AddNode(char firstPinYin, string pinYin, char chinese, int index) { }

		public bool MatchingNode(char firstPinYin, string pinYin, char chinese, List<ChineseNode> nodes) { }

	}

	private class FirstPinYinNode
	{
		private Dictionary<String, PinYinNode> PinYinNodes; //Field offset: 0x10

		public FirstPinYinNode() { }

		public ChineseNode AddNode(string pinYin, char chinese, int index) { }

		public bool MatchingNode(char firstPinYin, string pinYin, char chinese, List<ChineseNode> nodes) { }

	}

	private class PinYinNode
	{
		private Dictionary<Char, ChineseNode> ChineseNodes; //Field offset: 0x10

		public PinYinNode() { }

		public ChineseNode AddNode(char chinese, int index) { }

		public bool MatchingNode(char firstPinYin, string pinYin, char chinese, List<ChineseNode> nodes) { }

		public void ToAddNodes(List<ChineseNode> nodes) { }

	}

	private class TextLine
	{
		public List<TextLine> Lines; //Field offset: 0x10
		public char FristPinYin; //Field offset: 0x18
		public string PinYin; //Field offset: 0x20
		public char Chinese; //Field offset: 0x28
		public TextLine TopLine; //Field offset: 0x30

		public TextLine() { }

		public TextLine(char fristPinYin, string pinYin, char chinese) { }

		public TextLine(char fristPinYin, string pinYin, char chinese, TextLine line) { }

		public void Add(TextLine line) { }

	}

	private const char wordsSpace = '\u8'; //Field offset: 0x0
	private const char pinYinSpace = '\u9'; //Field offset: 0x0
	private static WordsSearch _pinyinSplit; //Field offset: 0x0
	private PinYinSearchType _type; //Field offset: 0x10
	private Int32[] _ids; //Field offset: 0x18
	private String[] _keywords; //Field offset: 0x20
	private Int32[] _indexs; //Field offset: 0x28
	private ChineseNode _root; //Field offset: 0x30

	public PinYinSearch(PinYinSearchType type = 0) { }

	private void buildKeywords(List<String> keySorts, List<String> keywords) { }

	private WordsSearch getPinYinSplit() { }

	private List<ChineseNode> matching(TextLine line) { }

	private void matching(TextLine line, List<ChineseNode> nodes, List<ChineseNode> results) { }

	public List<String> PickTexts(string text, bool keywordSort = false, int pickLength = 2) { }

	public List<PinYinSearchResult> PickTextWithIds(string text, bool keywordSort = false, int pickLength = 2) { }

	public List<Int32> SearchIds(string text, bool keywordSort = false) { }

	public List<String> SearchTexts(string text, bool keywordSort = false) { }

	public List<PinYinSearchResult> SearchTextWithIds(string text, bool keywordSort = false) { }

	public void SetKeywords(List<String> keywords) { }

	public void SetKeywords(List<String> keywords, List<Int32> ids) { }

	private void splitKeywords(string keyword, int baseIndex, List<String> results) { }

	private void splitKeywords(string py, int index, List<List`1<String>> ks, string keyword, int baseIndex, List<String> results) { }

	private List<String> SplitKeywords(List<String> keywords) { }

	private bool trySplitSearchText(string text, out TextLine root) { }

}

