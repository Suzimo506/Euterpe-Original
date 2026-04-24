namespace ToolGood.Words;

public class IllegalWordsSearchEx
{
	private class TreeNode
	{
		private char _char; //Field offset: 0x10
		private TreeNode _parent; //Field offset: 0x18
		private TreeNode _failure; //Field offset: 0x20
		private List<String> _results; //Field offset: 0x28
		private List<TreeNode> _transitionsAr; //Field offset: 0x30
		private Dictionary<Char, TreeNode> _transHash; //Field offset: 0x38

		public char Char
		{
			 get { } //Length: 5
		}

		public TreeNode Failure
		{
			 get { } //Length: 5
			 set { } //Length: 12
		}

		public TreeNode Parent
		{
			 get { } //Length: 5
		}

		public List<String> Results
		{
			 get { } //Length: 5
		}

		public List<TreeNode> Transitions
		{
			 get { } //Length: 5
		}

		public TreeNode(TreeNode parent, char c) { }

		public void AddResult(string result) { }

		public void AddTransition(TreeNode node) { }

		public bool ContainsTransition(char c) { }

		public char get_Char() { }

		public TreeNode get_Failure() { }

		public TreeNode get_Parent() { }

		public List<String> get_Results() { }

		public List<TreeNode> get_Transitions() { }

		public TreeNode GetTransition(char c) { }

		public TreeNode GetTransition(string text, int index) { }

		public void set_Failure(TreeNode value) { }

	}

	private class TrieNode
	{
		[CompilerGenerated]
		private bool <End>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private List<String> <Results>k__BackingField; //Field offset: 0x18
		private Dictionary<Char, TrieNode> m_values; //Field offset: 0x20
		private uint minflag; //Field offset: 0x28
		private uint maxflag; //Field offset: 0x2C
		[CompilerGenerated]
		private bool <IsRepeat>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		private TrieNode <Parent>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		private int <LastMatchLocation>k__BackingField; //Field offset: 0x40

		public bool End
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public bool IsRepeat
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public int LastMatchLocation
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public TrieNode Parent
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 12
		}

		public List<String> Results
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 12
		}

		public TrieNode() { }

		public void Add(TreeNode t, TrieNode node) { }

		[CompilerGenerated]
		public bool get_End() { }

		[CompilerGenerated]
		public bool get_IsRepeat() { }

		[CompilerGenerated]
		public int get_LastMatchLocation() { }

		[CompilerGenerated]
		public TrieNode get_Parent() { }

		[CompilerGenerated]
		public List<String> get_Results() { }

		public TrieNode GetParent(int pNum) { }

		[CompilerGenerated]
		public void set_End(bool value) { }

		[CompilerGenerated]
		public void set_IsRepeat(bool value) { }

		[CompilerGenerated]
		public void set_LastMatchLocation(int value) { }

		[CompilerGenerated]
		public void set_Parent(TrieNode value) { }

		[CompilerGenerated]
		public void set_Results(List<String> value) { }

		public TrieNode[] ToArray() { }

		public bool TryGetValue(char c, out TrieNode node) { }

	}

	private const string _skipList = " 	
~!@#$%^&*()_+-=【】、[]{}|;':"，。、《》？αβγδεζηθικλμνξοπρστυφχψωΑΒΓΔΕΖΗΘΙΚΛΜΝΞΟΠΡΣΤΥΦΧΨΩ。，、；：？！…—·ˉ¨‘’“”々～‖∶＂＇｀｜〃〔〕〈〉《》「」『』．〖〗【】（）［］｛｝ⅠⅡⅢⅣⅤⅥⅦⅧⅨⅩⅪⅫ⒈⒉⒊⒋⒌⒍⒎⒏⒐�"; //Field offset: 0x0
	private TrieNode _root; //Field offset: 0x10
	private TrieNode[] _first; //Field offset: 0x18
	private BitArray _skipBitArray; //Field offset: 0x20

	public IllegalWordsSearchEx(string skipList = null) { }

	private void addNode(TreeNode treeNode, TreeNode root, TrieNode tridNode, Dictionary<TreeNode, TrieNode> dict) { }

	private TreeNode BuildTreeWithBFS(ICollection<String> _keywords) { }

	public override bool ContainsAny(string text) { }

	public override List<IllegalWordsSearchResult> FindAll(string text) { }

	public override IllegalWordsSearchResult FindFirst(string text) { }

	public override string Replace(string text, char replaceChar = *) { }

	public void SetKeywords(ICollection<String> keywords) { }

	public void SetSkipWords(string skipList) { }

	private void SimplifyTree(TreeNode tn) { }

	private char ToSenseWord(char c) { }

}

