namespace Antlr.Runtime.Tree;

public class TreeRewriter : TreeParser
{
	protected bool showTransformations; //Field offset: 0x28
	protected ITokenStream originalTokenStream; //Field offset: 0x30
	protected ITreeAdaptor originalAdaptor; //Field offset: 0x38
	private Func<IAstRuleReturnScope> topdown_func; //Field offset: 0x40
	private Func<IAstRuleReturnScope> bottomup_func; //Field offset: 0x48

	public TreeRewriter(ITreeNodeStream input) { }

	public TreeRewriter(ITreeNodeStream input, RecognizerSharedState state) { }

	[CompilerGenerated]
	private IAstRuleReturnScope <.ctor>b__6_0() { }

	[CompilerGenerated]
	private IAstRuleReturnScope <.ctor>b__6_1() { }

	[CompilerGenerated]
	private object <Downup>b__10_0(object o) { }

	[CompilerGenerated]
	private object <Downup>b__10_1(object o) { }

	public override object ApplyOnce(object t, Func<IAstRuleReturnScope> whichRule) { }

	public override object ApplyRepeatedly(object t, Func<IAstRuleReturnScope> whichRule) { }

	public override IAstRuleReturnScope Bottomup() { }

	public override object Downup(object t) { }

	public override object Downup(object t, bool showTransformations) { }

	protected override void ReportTransformation(object oldTree, object newTree) { }

	public override IAstRuleReturnScope Topdown() { }

}

