namespace Antlr.Runtime;

public class UnbufferedTokenStream : LookaheadStream<IToken>, ITokenStream, IIntStream
{
	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected ITokenSource tokenSource; //Field offset: 0x40
	protected int tokenIndex; //Field offset: 0x48
	protected int channel; //Field offset: 0x4C

	public override string SourceName
	{
		 get { } //Length: 72
	}

	public override ITokenSource TokenSource
	{
		 get { } //Length: 5
	}

	public UnbufferedTokenStream(ITokenSource tokenSource) { }

	public override IToken Get(int i) { }

	public override string get_SourceName() { }

	public override ITokenSource get_TokenSource() { }

	public virtual bool IsEndOfFile(IToken o) { }

	public override int LA(int i) { }

	public virtual IToken NextElement() { }

	public override string ToString(int start, int stop) { }

	public override string ToString(IToken start, IToken stop) { }

}

