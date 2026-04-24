namespace Antlr.Runtime.Tree;

public class TreePatternParser
{
	protected TreePatternLexer tokenizer; //Field offset: 0x10
	protected int ttype; //Field offset: 0x18
	protected TreeWizard wizard; //Field offset: 0x20
	protected ITreeAdaptor adaptor; //Field offset: 0x28

	public TreePatternParser(TreePatternLexer tokenizer, TreeWizard wizard, ITreeAdaptor adaptor) { }

	public override object ParseNode() { }

	public override object ParseTree() { }

	public override object Pattern() { }

}

