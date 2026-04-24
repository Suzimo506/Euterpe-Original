namespace MS.Internal.Xml.XPath;

internal class Filter : AstNode
{
	private AstNode input; //Field offset: 0x10
	private AstNode condition; //Field offset: 0x18

	public AstNode Condition
	{
		 get { } //Length: 5
	}

	public AstNode Input
	{
		 get { } //Length: 5
	}

	public virtual XPathResultType ReturnType
	{
		 get { } //Length: 6
	}

	public virtual AstType Type
	{
		 get { } //Length: 6
	}

	public Filter(AstNode input, AstNode condition) { }

	public AstNode get_Condition() { }

	public AstNode get_Input() { }

	public virtual XPathResultType get_ReturnType() { }

	public virtual AstType get_Type() { }

}

