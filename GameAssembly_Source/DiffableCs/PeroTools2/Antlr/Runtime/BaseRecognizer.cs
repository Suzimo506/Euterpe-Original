namespace Antlr.Runtime;

public abstract class BaseRecognizer
{
	public const int MemoRuleFailed = -2; //Field offset: 0x0
	public const int MemoRuleUnknown = -1; //Field offset: 0x0
	public const int InitialFollowStackSize = 100; //Field offset: 0x0
	public const int DefaultTokenChannel = 0; //Field offset: 0x0
	public const int Hidden = 99; //Field offset: 0x0
	public const string NextTokenRuleName = "nextToken"; //Field offset: 0x0
	protected private RecognizerSharedState state; //Field offset: 0x10
	[CompilerGenerated]
	private TextWriter <TraceDestination>k__BackingField; //Field offset: 0x18

	public override int BacktrackingLevel
	{
		 get { } //Length: 26
		 set { } //Length: 26
	}

	public override IDebugEventListener DebugListener
	{
		 get { } //Length: 3
	}

	public override bool Failed
	{
		 get { } //Length: 27
	}

	public override string GrammarFileName
	{
		 get { } //Length: 3
	}

	public override int NumberOfSyntaxErrors
	{
		 get { } //Length: 26
	}

	public abstract string SourceName
	{
		 get { } //Length: 0
	}

	public override String[] TokenNames
	{
		 get { } //Length: 3
	}

	public TextWriter TraceDestination
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public BaseRecognizer() { }

	public BaseRecognizer(RecognizerSharedState state) { }

	public override bool AlreadyParsedRule(IIntStream input, int ruleIndex) { }

	public override void BeginResync() { }

	protected override BitSet CombineFollows(bool exact) { }

	protected override BitSet ComputeContextSensitiveRuleFOLLOW() { }

	protected override BitSet ComputeErrorRecoverySet() { }

	public override void ConsumeUntil(IIntStream input, int tokenType) { }

	public override void ConsumeUntil(IIntStream input, BitSet set) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected override void DebugBeginBacktrack(int level) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected override void DebugEndBacktrack(int level, bool successful) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected override void DebugEnterAlt(int alt) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected override void DebugEnterDecision(int decisionNumber, bool couldBacktrack) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected override void DebugEnterRule(string grammarFileName, string ruleName) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected override void DebugEnterSubRule(int decisionNumber) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected override void DebugExitDecision(int decisionNumber) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected override void DebugExitRule(string grammarFileName, string ruleName) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected override void DebugExitSubRule(int decisionNumber) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected override void DebugLocation(int line, int charPositionInLine) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected override void DebugRecognitionException(RecognitionException ex) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected override void DebugSemanticPredicate(bool result, string predicate) { }

	public override void DisplayRecognitionError(String[] tokenNames, RecognitionException e) { }

	public override void EmitErrorMessage(string msg) { }

	public override void EndResync() { }

	public override int get_BacktrackingLevel() { }

	public override IDebugEventListener get_DebugListener() { }

	public override bool get_Failed() { }

	public override string get_GrammarFileName() { }

	public override int get_NumberOfSyntaxErrors() { }

	public abstract string get_SourceName() { }

	public override String[] get_TokenNames() { }

	[CompilerGenerated]
	public TextWriter get_TraceDestination() { }

	protected override object GetCurrentInputSymbol(IIntStream input) { }

	public override string GetErrorHeader(RecognitionException e) { }

	public override string GetErrorMessage(RecognitionException e, String[] tokenNames) { }

	protected override object GetMissingSymbol(IIntStream input, RecognitionException e, int expectedTokenType, BitSet follow) { }

	public override int GetRuleMemoization(int ruleIndex, int ruleStartIndex) { }

	public override int GetRuleMemoizationCacheSize() { }

	public override string GetTokenErrorDisplay(IToken t) { }

	protected override void InitDFAs() { }

	public override object Match(IIntStream input, int ttype, BitSet follow) { }

	public override void MatchAny(IIntStream input) { }

	public override void Memoize(IIntStream input, int ruleIndex, int ruleStartIndex) { }

	public override bool MismatchIsMissingToken(IIntStream input, BitSet follow) { }

	public override bool MismatchIsUnwantedToken(IIntStream input, int ttype) { }

	protected void PopFollow() { }

	protected void PushFollow(BitSet fset) { }

	public override void Recover(IIntStream input, RecognitionException re) { }

	public override object RecoverFromMismatchedSet(IIntStream input, RecognitionException e, BitSet follow) { }

	protected override object RecoverFromMismatchedToken(IIntStream input, int ttype, BitSet follow) { }

	public override void ReportError(RecognitionException e) { }

	public override void Reset() { }

	public override void set_BacktrackingLevel(int value) { }

	[CompilerGenerated]
	public void set_TraceDestination(TextWriter value) { }

	public override List<String> ToStrings(ICollection<IToken> tokens) { }

	public override void TraceIn(string ruleName, int ruleIndex, object inputSymbol) { }

	public override void TraceOut(string ruleName, int ruleIndex, object inputSymbol) { }

}

