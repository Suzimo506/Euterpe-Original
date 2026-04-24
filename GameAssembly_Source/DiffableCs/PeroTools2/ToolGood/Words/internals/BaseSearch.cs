namespace ToolGood.Words.internals;

public abstract class BaseSearch
{
	protected TrieNode _root; //Field offset: 0x10
	protected TrieNode[] _first; //Field offset: 0x18

	protected BaseSearch() { }

	public override void SetKeywords(ICollection<String> _keywords) { }

	private void TryLinks(TrieNode node, TrieNode node2, Dictionary<TrieNode, TrieNode> links) { }

}

