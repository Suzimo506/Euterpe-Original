namespace ToolGood.Words;

public class PinYinSearchEx
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int32, Int32> <>9__30_0; //Field offset: 0x8
		public static Func<Int32, Int32> <>9__31_0; //Field offset: 0x10
		public static Func<Int32, Int32> <>9__32_0; //Field offset: 0x18
		public static Func<Int32, Int32> <>9__33_0; //Field offset: 0x20
		public static Func<Int32, Int32> <>9__34_0; //Field offset: 0x28
		public static Func<Byte, Byte> <>9__66_0; //Field offset: 0x30
		public static Func<UInt16, UInt16> <>9__67_0; //Field offset: 0x38
		public static Func<UInt16, UInt16> <>9__68_0; //Field offset: 0x40
		public static Func<String, String> <>9__77_0; //Field offset: 0x48

		private static <>c() { }

		public <>c() { }

		internal byte <buildCheckArray>b__66_0(byte q) { }

		internal ushort <buildCheckArray>b__67_0(ushort q) { }

		internal ushort <buildCheckArray>b__68_0(ushort q) { }

		internal int <PickTexts>b__33_0(int q) { }

		internal int <PickTextWithIds>b__34_0(int q) { }

		internal int <SearchIds>b__31_0(int q) { }

		internal int <SearchTexts>b__30_0(int q) { }

		internal int <SearchTextWithIds>b__32_0(int q) { }

		internal string <SplitKeywords>b__77_0(string q) { }

	}

	private class ChineseNode : IDisposable
	{
		public Dictionary<Byte, FirstPinYinNode> FirstPinYinNodes; //Field offset: 0x10
		public int RangeStart; //Field offset: 0x18
		public int RangeEnd; //Field offset: 0x1C
		public int Index; //Field offset: 0x20

		public bool IsEnd
		{
			 get { } //Length: 73
		}

		public ChineseNode() { }

		public ChineseNode AddNode(byte firstPinYin, ushort pinYin, ushort chinese, int index) { }

		public override void Dispose() { }

		public bool get_IsEnd() { }

		public Dictionary<UInt16, ChineseNode> GetNodes() { }

	}

	private class FirstPinYinNode : IDisposable
	{
		public Dictionary<UInt16, PinYinNode> PinYinNodes; //Field offset: 0x10

		public FirstPinYinNode() { }

		public ChineseNode AddNode(ushort pinYin, ushort chinese, int index) { }

		public override void Dispose() { }

	}

	private class MiniSearch : BaseSearch
	{

		public MiniSearch() { }

		public List<MiniSearchResult> FindAll(string text) { }

	}

	private class MiniSearchResult
	{
		[CompilerGenerated]
		private int <Start>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private int <End>k__BackingField; //Field offset: 0x14
		[CompilerGenerated]
		private string <Keyword>k__BackingField; //Field offset: 0x18

		public private int End
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private string Keyword
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public private int Start
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public MiniSearchResult(string keyword, int start, int end) { }

		[CompilerGenerated]
		public int get_End() { }

		[CompilerGenerated]
		public string get_Keyword() { }

		[CompilerGenerated]
		public int get_Start() { }

		[CompilerGenerated]
		private void set_End(int value) { }

		[CompilerGenerated]
		private void set_Keyword(string value) { }

		[CompilerGenerated]
		private void set_Start(int value) { }

	}

	private class PinYinNode : IDisposable
	{
		public Dictionary<UInt16, ChineseNode> ChineseNodes; //Field offset: 0x10

		public PinYinNode() { }

		public ChineseNode AddNode(ushort chinese, int index) { }

		public override void Dispose() { }

	}

	private class TextLine
	{
		public List<TextLine> Lines; //Field offset: 0x10
		public byte FristPinYin; //Field offset: 0x18
		public ushort PinYin; //Field offset: 0x1A
		public ushort Chinese; //Field offset: 0x1C
		public TextLine TopLine; //Field offset: 0x20
		public bool IsError; //Field offset: 0x28

		public static TextLine Error
		{
			 get { } //Length: 81
		}

		public TextLine() { }

		public TextLine(byte fristPinYin, ushort pinYin, ushort chinese) { }

		public TextLine(byte fristPinYin, ushort pinYin, ushort chinese, TextLine line) { }

		public void Add(TextLine line) { }

		public void FilterError() { }

		public static TextLine get_Error() { }

	}

	private class WordNode
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<WordNode, String> <>9__10_0; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal string <SetSort2>b__10_0(WordNode q) { }

		}

		public List<WordNode> Nodes; //Field offset: 0x10
		private Dictionary<String, WordNode> dict; //Field offset: 0x18
		public string Text; //Field offset: 0x20
		public int Count; //Field offset: 0x28
		public int Index; //Field offset: 0x2C
		public int fpyIndex; //Field offset: 0x30
		public int pyIndex; //Field offset: 0x34
		public int cIndex; //Field offset: 0x38

		public WordNode() { }

		public void Add(string fpy, string py, string chinese) { }

		public void SetIndex() { }

		public void SetSort2() { }

	}

	private const char wordsSpace = '\u8'; //Field offset: 0x0
	private const char pinYinSpace = '\u9'; //Field offset: 0x0
	private static MiniSearch _pinyinSplit; //Field offset: 0x0
	private PinYinSearchType _type; //Field offset: 0x10
	private Int32[] _ids; //Field offset: 0x18
	private String[] _keywords; //Field offset: 0x20
	private Int32[] _indexs; //Field offset: 0x28
	private UInt16[] _toWord1; //Field offset: 0x30
	private Dictionary<String, UInt16> _toWord2; //Field offset: 0x38
	private Byte[] _toFirstPinYin; //Field offset: 0x40
	private UInt16[] _wordToPinYin; //Field offset: 0x48
	private Byte[] _pinYinToFirstPinYin; //Field offset: 0x50
	public UInt16[] _pinYinStart; //Field offset: 0x58
	public UInt16[] _firstPinYinStart; //Field offset: 0x60
	private UInt16[] _word; //Field offset: 0x68
	private Int32[] _start; //Field offset: 0x70
	private Int32[] _end; //Field offset: 0x78
	private BitArray _isEnd; //Field offset: 0x80
	private Int32[] _fpyIndexBase; //Field offset: 0x88
	private Byte[] _fpy; //Field offset: 0x90
	private Int32[] _pyIndexBase; //Field offset: 0x98
	private UInt16[] _py; //Field offset: 0xA0
	private Int32[] _wordIndexBase; //Field offset: 0xA8
	private Int32[] _wordCheck; //Field offset: 0xB0
	private List<UInt16> _word_firstPinYin; //Field offset: 0xB8

	public PinYinSearchEx(PinYinSearchType type = 0) { }

	private void buildCheckArray(ChineseNode root) { }

	private void buildCheckArray(PinYinNode root, List<Byte> fpy, List<Int32> pyIndexBase, List<UInt16> py, List<Int32> wordIndexBase, List<Int32> wordCheck, int baseIndex) { }

	private void buildCheckArray(ChineseNode root, List<Byte> fpy, List<Int32> pyIndexBase, List<UInt16> py, List<Int32> wordIndexBase, List<Int32> wordCheck) { }

	private void buildCheckArray(FirstPinYinNode root, List<Byte> fpy, List<Int32> pyIndexBase, List<UInt16> py, List<Int32> wordIndexBase, List<Int32> wordCheck, int baseIndex) { }

	private ChineseNode buildNode(List<String> keySort, List<String> keywords) { }

	private void buildNodeInfo(ChineseNode node, List<UInt16> word, List<Int32> start, List<Int32> end, List<Boolean> isEnd, ref int index) { }

	private void buildNodeInfo(ChineseNode root) { }

	private void buildToArray(ChineseNode root) { }

	private byte getFirstPinYin(ushort word) { }

	private ushort getPinYin(ushort word) { }

	private MiniSearch getPinYinSplit() { }

	private ushort getWord(ushort word) { }

	private ushort getWord(string text) { }

	private void initDictionary(List<String> keywords) { }

	private void loadFile(string filePath) { }

	public void LoadFile(string filePath) { }

	private void matchChinese(TextLine line, int baseIndex, List<Int32> nextBaseList) { }

	private void matchFirstPinYin(TextLine line, int baseIndex, List<Int32> nextBaseList) { }

	private void matchPinYin(TextLine line, int baseIndex, List<Int32> nextBaseList) { }

	public List<String> PickTexts(string text, bool keywordSort = false, int pickLength = 2) { }

	public List<PinYinSearchResult> PickTextWithIds(string text, bool keywordSort = false, int pickLength = 2) { }

	private BitArray readBitArray(BinaryReader br) { }

	private Byte[] readByteArray(BinaryReader br) { }

	private Dictionary<String, UInt16> readDictionary(BinaryReader br) { }

	private Int32[] readIntArray(BinaryReader br) { }

	private String[] readStringArray(BinaryReader br) { }

	private UInt16[] readWordArray(BinaryReader br) { }

	private void saveFile(string filePath) { }

	public void SaveFile(string filePath) { }

	public List<Int32> SearchIds(string text, bool keywordSort = false) { }

	private void searchIndexs(TextLine line, List<Int32> baseList, List<Int32> results) { }

	private List<Int32> searchIndexs(string text) { }

	public List<String> SearchTexts(string text, bool keywordSort = false) { }

	public List<PinYinSearchResult> SearchTextWithIds(string text, bool keywordSort = false) { }

	private void setKeywords(List<String> keywords) { }

	public void SetKeywords(List<String> keywords, List<Int32> ids) { }

	public void SetKeywords(List<String> keywords) { }

	private void splitKeywords(string py, int index, List<List`1<String>> ks, string keyword, int baseIndex, List<String> results) { }

	private void splitKeywords(string keyword, int baseIndex, List<String> results) { }

	private List<String> SplitKeywords(List<String> keywords) { }

	private bool trySplitSearchText(string text, out TextLine root) { }

	private void write(BinaryWriter bw, Dictionary<String, UInt16> w) { }

	private void write(BinaryWriter bw, Byte[] w) { }

	private void write(BinaryWriter bw, UInt16[] w) { }

	private void write(BinaryWriter bw, String[] texts) { }

	private void write(BinaryWriter bw, Int32[] w) { }

	private void write(BinaryWriter bw, BitArray array) { }

}

