namespace Antlr.Runtime.Tree;

public class RewriteRuleNodeStream : RewriteRuleElementStream
{

	public RewriteRuleNodeStream(ITreeAdaptor adaptor, string elementDescription) { }

	public RewriteRuleNodeStream(ITreeAdaptor adaptor, string elementDescription, object oneElement) { }

	public RewriteRuleNodeStream(ITreeAdaptor adaptor, string elementDescription, IList elements) { }

	protected virtual object Dup(object el) { }

	public override object NextNode() { }

	protected virtual object ToTree(object el) { }

}

