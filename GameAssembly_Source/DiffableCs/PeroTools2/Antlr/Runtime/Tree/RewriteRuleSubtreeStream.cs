namespace Antlr.Runtime.Tree;

public class RewriteRuleSubtreeStream : RewriteRuleElementStream
{

	public RewriteRuleSubtreeStream(ITreeAdaptor adaptor, string elementDescription) { }

	public RewriteRuleSubtreeStream(ITreeAdaptor adaptor, string elementDescription, object oneElement) { }

	public RewriteRuleSubtreeStream(ITreeAdaptor adaptor, string elementDescription, IList elements) { }

	protected virtual object Dup(object el) { }

	public override object NextNode() { }

}

