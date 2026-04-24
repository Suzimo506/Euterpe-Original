//Type is in global namespace

[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class NCalcLexer : Lexer
{
	private class DFA14 : DFA
	{
		private const string DFA14_eotS = "￿!￿#￿'),￿1￿6￿9￿￿<="; //Field offset: 0x0
		private const string DFA14_eofS = "C�"; //Field offset: 0x0
		private const string DFA14_minS = "	=￿&￿<=￿nor|￿ra+.￿dt0￿ul0￿0￿"; //Field offset: 0x0
		private const string DFA14_maxS = "~=￿&￿>=>￿nor|￿ra9e￿dtz￿ul9￿z￿"; //Field offset: 0x0
		private const string DFA14_acceptS = "￿￿	
￿￿￿#$%&!(￿￿'"￿"; //Field offset: 0x0
		private const string DFA14_specialS = "C￿"; //Field offset: 0x0
		private static readonly String[] DFA14_transitionS; //Field offset: 0x0
		private static readonly Int16[] DFA14_eot; //Field offset: 0x8
		private static readonly Int16[] DFA14_eof; //Field offset: 0x10
		private static readonly Char[] DFA14_min; //Field offset: 0x18
		private static readonly Char[] DFA14_max; //Field offset: 0x20
		private static readonly Int16[] DFA14_accept; //Field offset: 0x28
		private static readonly Int16[] DFA14_special; //Field offset: 0x30
		private static readonly Int16[][] DFA14_transition; //Field offset: 0x38

		public virtual string Description
		{
			 get { } //Length: 43
		}

		private static DFA14() { }

		public DFA14(BaseRecognizer recognizer) { }

		public virtual void Error(NoViableAltException nvae) { }

		public virtual string get_Description() { }

	}

	private class DFA7 : DFA
	{
		private const string DFA7_eotS = "�"; //Field offset: 0x0
		private const string DFA7_eofS = "�"; //Field offset: 0x0
		private const string DFA7_minS = ".�"; //Field offset: 0x0
		private const string DFA7_maxS = "9e�"; //Field offset: 0x0
		private const string DFA7_acceptS = "￿"; //Field offset: 0x0
		private const string DFA7_specialS = "￿"; //Field offset: 0x0
		private static readonly String[] DFA7_transitionS; //Field offset: 0x0
		private static readonly Int16[] DFA7_eot; //Field offset: 0x8
		private static readonly Int16[] DFA7_eof; //Field offset: 0x10
		private static readonly Char[] DFA7_min; //Field offset: 0x18
		private static readonly Char[] DFA7_max; //Field offset: 0x20
		private static readonly Int16[] DFA7_accept; //Field offset: 0x28
		private static readonly Int16[] DFA7_special; //Field offset: 0x30
		private static readonly Int16[][] DFA7_transition; //Field offset: 0x38

		public virtual string Description
		{
			 get { } //Length: 43
		}

		private static DFA7() { }

		public DFA7(BaseRecognizer recognizer) { }

		public virtual void Error(NoViableAltException nvae) { }

		public virtual string get_Description() { }

	}

	public const int EOF = -1; //Field offset: 0x0
	public const int T__30 = 30; //Field offset: 0x0
	public const int T__31 = 31; //Field offset: 0x0
	public const int T__32 = 32; //Field offset: 0x0
	public const int T__33 = 33; //Field offset: 0x0
	public const int T__34 = 34; //Field offset: 0x0
	public const int T__35 = 35; //Field offset: 0x0
	public const int T__36 = 36; //Field offset: 0x0
	public const int T__37 = 37; //Field offset: 0x0
	public const int T__38 = 38; //Field offset: 0x0
	public const int T__29 = 29; //Field offset: 0x0
	public const int T__39 = 39; //Field offset: 0x0
	public const int T__41 = 41; //Field offset: 0x0
	public const int T__42 = 42; //Field offset: 0x0
	public const int T__43 = 43; //Field offset: 0x0
	public const int T__44 = 44; //Field offset: 0x0
	public const int T__45 = 45; //Field offset: 0x0
	public const int T__46 = 46; //Field offset: 0x0
	public const int T__47 = 47; //Field offset: 0x0
	public const int T__48 = 48; //Field offset: 0x0
	private static readonly Boolean[] decisionCanBacktrack; //Field offset: 0x0
	public const int T__40 = 40; //Field offset: 0x0
	public const int T__28 = 28; //Field offset: 0x0
	public const int T__27 = 27; //Field offset: 0x0
	public const int NAME = 14; //Field offset: 0x0
	public const int E = 6; //Field offset: 0x0
	public const int EscapeSequence = 7; //Field offset: 0x0
	public const int FALSE = 8; //Field offset: 0x0
	public const int FLOAT = 9; //Field offset: 0x0
	public const int HexDigit = 10; //Field offset: 0x0
	public const int ID = 11; //Field offset: 0x0
	public const int INTEGER = 12; //Field offset: 0x0
	public const int LETTER = 13; //Field offset: 0x0
	public const int T__26 = 26; //Field offset: 0x0
	public const int DIGIT = 5; //Field offset: 0x0
	public const int STRING = 15; //Field offset: 0x0
	public const int UnicodeEscape = 17; //Field offset: 0x0
	public const int WS = 18; //Field offset: 0x0
	public const int T__19 = 19; //Field offset: 0x0
	public const int T__20 = 20; //Field offset: 0x0
	public const int T__21 = 21; //Field offset: 0x0
	public const int T__22 = 22; //Field offset: 0x0
	public const int T__23 = 23; //Field offset: 0x0
	public const int T__24 = 24; //Field offset: 0x0
	public const int T__25 = 25; //Field offset: 0x0
	public const int TRUE = 16; //Field offset: 0x0
	public const int DATETIME = 4; //Field offset: 0x0
	private DFA7 dfa7; //Field offset: 0x28
	private DFA14 dfa14; //Field offset: 0x30

	public virtual string GrammarFileName
	{
		 get { } //Length: 43
	}

	private static NCalcLexer() { }

	public NCalcLexer(ICharStream input, RecognizerSharedState state) { }

	public NCalcLexer() { }

	public NCalcLexer(ICharStream input) { }

	public virtual string get_GrammarFileName() { }

	protected virtual void InitDFAs() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mDATETIME() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mDIGIT() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mE() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mEscapeSequence() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mFALSE() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mFLOAT() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mHexDigit() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mID() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mINTEGER() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mLETTER() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mNAME() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mSTRING() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__19() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__20() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__21() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__22() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__23() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__24() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__25() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__26() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__27() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__28() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__29() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__30() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__31() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__32() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__33() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__34() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__35() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__36() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__37() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__38() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__39() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__40() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__41() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__42() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__43() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__44() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__45() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__46() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__47() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mT__48() { }

	public virtual void mTokens() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mTRUE() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mUnicodeEscape() { }

	[GrammarRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void mWS() { }

}

