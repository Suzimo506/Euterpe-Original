namespace Antlr.Runtime.Tree;

public class TreeParser : BaseRecognizer
{
	public const int DOWN = 2; //Field offset: 0x0
	public const int UP = 3; //Field offset: 0x0
	private static string dotdot; //Field offset: 0x0
	private static string doubleEtc; //Field offset: 0x8
	private static Regex dotdotPattern; //Field offset: 0x10
	private static Regex doubleEtcPattern; //Field offset: 0x18
	protected ITreeNodeStream input; //Field offset: 0x20

	public virtual string SourceName
	{
		 get { } //Length: 72
	}

	private static TreeParser() { }

	public TreeParser(ITreeNodeStream input) { }

	public TreeParser(ITreeNodeStream input, RecognizerSharedState state) { }

	public virtual string get_SourceName() { }

	protected virtual object GetCurrentInputSymbol(IIntStream input) { }

	public virtual string GetErrorHeader(RecognitionException e) { }

	public virtual string GetErrorMessage(RecognitionException e, String[] tokenNames) { }

	protected virtual object GetMissingSymbol(IIntStream input, RecognitionException e, int expectedTokenType, BitSet follow) { }

	public override ITreeNodeStream GetTreeNodeStream() { }

	public virtual void MatchAny(IIntStream ignore) { }

	protected virtual object RecoverFromMismatchedToken(IIntStream input, int ttype, BitSet follow) { }

	public virtual void Reset() { }

	public override void SetTreeNodeStream(ITreeNodeStream input) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override void TraceIn(string ruleName, int ruleIndex) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override void TraceOut(string ruleName, int ruleIndex) { }

}

