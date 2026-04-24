namespace ToolGood.Words;

public class WordsSearchResult
{
	[CompilerGenerated]
	private bool <Success>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <Start>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private int <End>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Keyword>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <Index>k__BackingField; //Field offset: 0x28
	private int _hash; //Field offset: 0x2C

	public static WordsSearchResult Empty
	{
		 get { } //Length: 105
	}

	public private int End
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int Index
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

	public private bool Success
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	internal WordsSearchResult(string keyword, int start, int end, int index) { }

	private WordsSearchResult() { }

	public static WordsSearchResult get_Empty() { }

	[CompilerGenerated]
	public int get_End() { }

	[CompilerGenerated]
	public int get_Index() { }

	[CompilerGenerated]
	public string get_Keyword() { }

	[CompilerGenerated]
	public int get_Start() { }

	[CompilerGenerated]
	public bool get_Success() { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	private void set_End(int value) { }

	[CompilerGenerated]
	private void set_Index(int value) { }

	[CompilerGenerated]
	private void set_Keyword(string value) { }

	[CompilerGenerated]
	private void set_Start(int value) { }

	[CompilerGenerated]
	private void set_Success(bool value) { }

	public virtual string ToString() { }

}

