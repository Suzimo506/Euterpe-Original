namespace Antlr.Runtime.Tree;

public class RewriteRuleTokenStream : RewriteRuleElementStream
{

	public RewriteRuleTokenStream(ITreeAdaptor adaptor, string elementDescription) { }

	public RewriteRuleTokenStream(ITreeAdaptor adaptor, string elementDescription, object oneElement) { }

	public RewriteRuleTokenStream(ITreeAdaptor adaptor, string elementDescription, IList elements) { }

	protected virtual object Dup(object el) { }

	public override object NextNode() { }

	public override IToken NextToken() { }

	protected virtual object ToTree(object el) { }

}

