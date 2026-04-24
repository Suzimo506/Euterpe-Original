namespace MS.Internal.Xml.XPath;

internal class Group : AstNode
{
	private AstNode groupNode; //Field offset: 0x10

	public AstNode GroupNode
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

	public Group(AstNode groupNode) { }

	public AstNode get_GroupNode() { }

	public virtual XPathResultType get_ReturnType() { }

	public virtual AstType get_Type() { }

}

