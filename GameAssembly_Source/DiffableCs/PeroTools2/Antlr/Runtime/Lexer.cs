namespace Antlr.Runtime;

public abstract class Lexer : BaseRecognizer, ITokenSource
{
	protected ICharStream input; //Field offset: 0x20

	public override int CharIndex
	{
		 get { } //Length: 72
	}

	public int CharPositionInLine
	{
		 get { } //Length: 72
		 set { } //Length: 86
	}

	public override ICharStream CharStream
	{
		 get { } //Length: 5
		 set { } //Length: 90
	}

	public int Line
	{
		 get { } //Length: 72
		 set { } //Length: 86
	}

	public virtual string SourceName
	{
		 get { } //Length: 72
	}

	public string Text
	{
		 get { } //Length: 171
		 set { } //Length: 34
	}

	public Lexer() { }

	public Lexer(ICharStream input) { }

	public Lexer(ICharStream input, RecognizerSharedState state) { }

	public override IToken Emit() { }

	public override void Emit(IToken token) { }

	public override int get_CharIndex() { }

	public int get_CharPositionInLine() { }

	public override ICharStream get_CharStream() { }

	public int get_Line() { }

	public virtual string get_SourceName() { }

	public string get_Text() { }

	public override string GetCharErrorDisplay(int c) { }

	public virtual string GetErrorMessage(RecognitionException e, String[] tokenNames) { }

	public override void Match(string s) { }

	public override void Match(int c) { }

	public override void MatchAny() { }

	public override void MatchRange(int a, int b) { }

	public abstract void mTokens() { }

	public override IToken NextToken() { }

	public override void Recover(RecognitionException re) { }

	public virtual void ReportError(RecognitionException e) { }

	public virtual void Reset() { }

	public void set_CharPositionInLine(int value) { }

	public override void set_CharStream(ICharStream value) { }

	public void set_Line(int value) { }

	public void set_Text(string value) { }

	public override void Skip() { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override void TraceIn(string ruleName, int ruleIndex) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override void TraceOut(string ruleName, int ruleIndex) { }

}

