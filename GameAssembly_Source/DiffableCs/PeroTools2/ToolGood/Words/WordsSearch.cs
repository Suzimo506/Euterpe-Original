namespace ToolGood.Words;

public class WordsSearch
{
	private class TrieNode
	{
		[CompilerGenerated]
		private bool <End>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private List<KeyValuePair`2<String, Int32>> <Results>k__BackingField; //Field offset: 0x18
		internal Dictionary<Char, TrieNode> m_values; //Field offset: 0x20
		private uint minflag; //Field offset: 0x28
		private uint maxflag; //Field offset: 0x2C

		public bool End
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public List<KeyValuePair`2<String, Int32>> Results
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 12
		}

		public TrieNode() { }

		public TrieNode Add(char c) { }

		[CompilerGenerated]
		public bool get_End() { }

		[CompilerGenerated]
		public List<KeyValuePair`2<String, Int32>> get_Results() { }

		public void Merge(TrieNode node) { }

		[CompilerGenerated]
		public void set_End(bool value) { }

		[CompilerGenerated]
		public void set_Results(List<KeyValuePair`2<String, Int32>> value) { }

		public void SetResults(string text, int index) { }

		public bool TryGetValue(char c, out TrieNode node) { }

	}

	private TrieNode[] _first; //Field offset: 0x10

	public WordsSearch() { }

	public bool ContainsAny(string text) { }

	public List<WordsSearchResult> FindAll(string text) { }

	public WordsSearchResult FindFirst(string text) { }

	public string Replace(string text, char replaceChar = *) { }

	public void SetKeywords(ICollection<String> keywords) { }

	public void SetKeywords(ICollection<String> keywords, ICollection<Int32> indexs) { }

	public void SetKeywords(IDictionary<String, Int32> keywords) { }

	private void TryLinks(TrieNode node, TrieNode node2, Dictionary<TrieNode, TrieNode> links) { }

}

