namespace Antlr.Runtime;

public class BufferedTokenStream : ITokenStream, IIntStream, ITokenStreamInformation
{
	private ITokenSource _tokenSource; //Field offset: 0x10
	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected List<IToken> _tokens; //Field offset: 0x18
	private int _lastMarker; //Field offset: 0x20
	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected int _p; //Field offset: 0x24
	[CompilerGenerated]
	private int <Range>k__BackingField; //Field offset: 0x28

	public override int Count
	{
		 get { } //Length: 59
	}

	public override int Index
	{
		 get { } //Length: 4
	}

	public override IToken LastRealToken
	{
		 get { } //Length: 229
	}

	public override IToken LastToken
	{
		 get { } //Length: 22
	}

	public override int MaxLookBehind
	{
		 get { } //Length: 6
	}

	public override int Range
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override string SourceName
	{
		 get { } //Length: 72
	}

	public override ITokenSource TokenSource
	{
		 get { } //Length: 5
		 set { } //Length: 102
	}

	public BufferedTokenStream() { }

	public BufferedTokenStream(ITokenSource tokenSource) { }

	public override void Consume() { }

	protected override void Fetch(int n) { }

	public override void Fill() { }

	public override IToken Get(int i) { }

	public override int get_Count() { }

	public override int get_Index() { }

	public override IToken get_LastRealToken() { }

	public override IToken get_LastToken() { }

	public override int get_MaxLookBehind() { }

	[CompilerGenerated]
	public override int get_Range() { }

	public override string get_SourceName() { }

	public override ITokenSource get_TokenSource() { }

	public override List<IToken> GetTokens(int start, int stop, BitSet types) { }

	public override List<IToken> GetTokens(int start, int stop, IEnumerable<Int32> types) { }

	public override List<IToken> GetTokens() { }

	public override List<IToken> GetTokens(int start, int stop) { }

	public override List<IToken> GetTokens(int start, int stop, int ttype) { }

	public override int LA(int i) { }

	protected override IToken LB(int k) { }

	public override IToken LT(int k) { }

	public override int Mark() { }

	public override void Release(int marker) { }

	public override void Reset() { }

	public override void Rewind(int marker) { }

	public override void Rewind() { }

	public override void Seek(int index) { }

	[CompilerGenerated]
	protected override void set_Range(int value) { }

	public override void set_TokenSource(ITokenSource value) { }

	protected override void Setup() { }

	protected override void Sync(int i) { }

	public override string ToString(IToken start, IToken stop) { }

	public virtual string ToString() { }

	public override string ToString(int start, int stop) { }

}

