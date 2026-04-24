namespace Antlr.Runtime;

public class Parser : BaseRecognizer
{
	public ITokenStream input; //Field offset: 0x20

	public virtual string SourceName
	{
		 get { } //Length: 72
	}

	public override ITokenStream TokenStream
	{
		 get { } //Length: 5
		 set { } //Length: 90
	}

	public Parser(ITokenStream input) { }

	public Parser(ITokenStream input, RecognizerSharedState state) { }

	public virtual string get_SourceName() { }

	public override ITokenStream get_TokenStream() { }

	protected virtual object GetCurrentInputSymbol(IIntStream input) { }

	protected virtual object GetMissingSymbol(IIntStream input, RecognitionException e, int expectedTokenType, BitSet follow) { }

	public virtual void Reset() { }

	public override void set_TokenStream(ITokenStream value) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override void TraceIn(string ruleName, int ruleIndex) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override void TraceOut(string ruleName, int ruleIndex) { }

}

