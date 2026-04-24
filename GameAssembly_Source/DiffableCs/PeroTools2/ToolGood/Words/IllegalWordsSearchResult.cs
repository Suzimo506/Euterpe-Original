namespace ToolGood.Words;

public class IllegalWordsSearchResult
{
	[CompilerGenerated]
	private bool <Success>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <Start>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private int <End>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <SrcString>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <Keyword>k__BackingField; //Field offset: 0x28

	public static IllegalWordsSearchResult Empty
	{
		 get { } //Length: 114
	}

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

	public private string SrcString
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

	internal IllegalWordsSearchResult(string keyword, int start, int end, string srcText) { }

	private IllegalWordsSearchResult() { }

	public static IllegalWordsSearchResult get_Empty() { }

	[CompilerGenerated]
	public int get_End() { }

	[CompilerGenerated]
	public string get_Keyword() { }

	[CompilerGenerated]
	public string get_SrcString() { }

	[CompilerGenerated]
	public int get_Start() { }

	[CompilerGenerated]
	public bool get_Success() { }

	[CompilerGenerated]
	private void set_End(int value) { }

	[CompilerGenerated]
	private void set_Keyword(string value) { }

	[CompilerGenerated]
	private void set_SrcString(string value) { }

	[CompilerGenerated]
	private void set_Start(int value) { }

	[CompilerGenerated]
	private void set_Success(bool value) { }

	public virtual string ToString() { }

}

