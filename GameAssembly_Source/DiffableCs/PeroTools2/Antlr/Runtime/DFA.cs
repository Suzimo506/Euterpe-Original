namespace Antlr.Runtime;

public class DFA
{
	protected Int16[] eot; //Field offset: 0x10
	protected Int16[] eof; //Field offset: 0x18
	protected Char[] min; //Field offset: 0x20
	protected Char[] max; //Field offset: 0x28
	protected Int16[] accept; //Field offset: 0x30
	protected Int16[] special; //Field offset: 0x38
	protected Int16[][] transition; //Field offset: 0x40
	protected int decisionNumber; //Field offset: 0x48
	protected BaseRecognizer recognizer; //Field offset: 0x50
	public readonly bool debug; //Field offset: 0x58
	[CompilerGenerated]
	private SpecialStateTransitionHandler <SpecialStateTransition>k__BackingField; //Field offset: 0x60

	public override string Description
	{
		 get { } //Length: 43
	}

	public private SpecialStateTransitionHandler SpecialStateTransition
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public DFA() { }

	public DFA(SpecialStateTransitionHandler specialStateTransition) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected override void DebugRecognitionException(RecognitionException ex) { }

	public override void Error(NoViableAltException nvae) { }

	public override string get_Description() { }

	[CompilerGenerated]
	public SpecialStateTransitionHandler get_SpecialStateTransition() { }

	protected override void NoViableAlt(int s, IIntStream input) { }

	public override int Predict(IIntStream input) { }

	[CompilerGenerated]
	private void set_SpecialStateTransition(SpecialStateTransitionHandler value) { }

	private static int SpecialStateTransitionDefault(DFA dfa, int s, IIntStream input) { }

	public static Int16[] UnpackEncodedString(string encodedString) { }

	public static Char[] UnpackEncodedStringToUnsignedChars(string encodedString) { }

}

