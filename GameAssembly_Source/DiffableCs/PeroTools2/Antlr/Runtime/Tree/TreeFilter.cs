namespace Antlr.Runtime.Tree;

public class TreeFilter : TreeParser
{
	protected ITokenStream originalTokenStream; //Field offset: 0x28
	protected ITreeAdaptor originalAdaptor; //Field offset: 0x30

	public TreeFilter(ITreeNodeStream input) { }

	public TreeFilter(ITreeNodeStream input, RecognizerSharedState state) { }

	[CompilerGenerated]
	private object <Downup>b__5_0(object o) { }

	[CompilerGenerated]
	private object <Downup>b__5_1(object o) { }

	public override void ApplyOnce(object t, Action whichRule) { }

	protected override void Bottomup() { }

	public override void Downup(object t) { }

	protected override void Topdown() { }

}

