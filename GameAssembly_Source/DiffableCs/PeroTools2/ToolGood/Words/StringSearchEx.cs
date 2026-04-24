namespace ToolGood.Words;

public class StringSearchEx
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<Char, Int32>, Int32> <>9__18_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<Char, Int32>, Char> <>9__18_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <CreateDict>b__18_0(KeyValuePair<Char, Int32> q) { }

		internal char <CreateDict>b__18_1(KeyValuePair<Char, Int32> q) { }

	}

	private class TrieNode
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<KeyValuePair`2<Char, TrieNode>, Char> <>9__16_0; //Field offset: 0x8
			public static Func<KeyValuePair`2<Char, TrieNode>, Char> <>9__16_1; //Field offset: 0x10
			public static Func<KeyValuePair`2<Char, TrieNode>, Int32> <>9__16_2; //Field offset: 0x18
			public static Func<KeyValuePair`2<Char, TrieNode>, UInt32> <>9__16_3; //Field offset: 0x20

			private static <>c() { }

			public <>c() { }

			internal char <Rank>b__16_0(KeyValuePair<Char, TrieNode> q) { }

			internal char <Rank>b__16_1(KeyValuePair<Char, TrieNode> q) { }

			internal int <Rank>b__16_2(KeyValuePair<Char, TrieNode> q) { }

			internal uint <Rank>b__16_3(KeyValuePair<Char, TrieNode> q) { }

		}

		public char Char; //Field offset: 0x10
		internal bool End; //Field offset: 0x12
		internal List<Int32> Results; //Field offset: 0x18
		internal Dictionary<Char, TrieNode> m_values; //Field offset: 0x20
		internal Dictionary<Char, TrieNode> merge_values; //Field offset: 0x28
		private uint minflag; //Field offset: 0x30
		private uint maxflag; //Field offset: 0x34
		internal int Next; //Field offset: 0x38
		private int Count; //Field offset: 0x3C

		public TrieNode() { }

		public TrieNode Add(char c) { }

		public int GetMaxLength() { }

		public void Merge(TrieNode node, Dictionary<TrieNode, TrieNode> links) { }

		public int Rank(TrieNode[] has) { }

		private void Rank(ref int maxCount, ref int start, Boolean[] seats, TrieNode[] has) { }

		public void SetResults(int text) { }

		private void SetSeats(int next, ref int maxCount, Boolean[] seats, TrieNode[] has) { }

		public bool TryGetValue(char c, out TrieNode node) { }

	}

	private String[] _keywords; //Field offset: 0x10
	private Int32[][] _guides; //Field offset: 0x18
	private Int32[] _key; //Field offset: 0x20
	private Int32[] _next; //Field offset: 0x28
	private Int32[] _check; //Field offset: 0x30
	private Int32[] _dict; //Field offset: 0x38

	public StringSearchEx() { }

	private void build(TrieNode root, int length) { }

	private Int32[] ByteArrToIntArr(Byte[] btArr) { }

	public bool ContainsAny(string text) { }

	private int CreateDict(ICollection<String> keywords) { }

	public List<String> FindAll(string text) { }

	public string FindFirst(string text) { }

	private Byte[] IntArrToByteArr(Int32[] intArr) { }

	public void Load(string filePath) { }

	public string Replace(string text, char replaceChar = *) { }

	public void Save(string fileName) { }

	public void SetKeywords(ICollection<String> keywords) { }

	private void TryLinks(TrieNode node, TrieNode node2, Dictionary<TrieNode, TrieNode> links, TrieNode root) { }

}

