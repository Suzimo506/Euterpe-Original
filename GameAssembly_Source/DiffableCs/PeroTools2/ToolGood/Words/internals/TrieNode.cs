namespace ToolGood.Words.internals;

public class TrieNode
{
	[CompilerGenerated]
	private bool <End>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<String> <Results>k__BackingField; //Field offset: 0x18
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

	public private List<String> Results
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public TrieNode() { }

	public TrieNode Add(char c) { }

	[CompilerGenerated]
	public bool get_End() { }

	[CompilerGenerated]
	public List<String> get_Results() { }

	public void Merge(TrieNode node, Dictionary<TrieNode, TrieNode> links) { }

	[CompilerGenerated]
	public void set_End(bool value) { }

	[CompilerGenerated]
	private void set_Results(List<String> value) { }

	public void SetResults(string text) { }

	public TrieNode[] ToArray() { }

	public ICollection<TrieNode> Transitions() { }

	public bool TryGetValue(char c, out TrieNode node) { }

}

