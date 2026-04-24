namespace MS.Internal.Xml.XPath;

internal class Operand : AstNode
{
	private XPathResultType type; //Field offset: 0x10
	private object val; //Field offset: 0x18

	public object OperandValue
	{
		 get { } //Length: 5
	}

	public virtual XPathResultType ReturnType
	{
		 get { } //Length: 4
	}

	public virtual AstType Type
	{
		 get { } //Length: 6
	}

	public Operand(string val) { }

	public Operand(double val) { }

	public object get_OperandValue() { }

	public virtual XPathResultType get_ReturnType() { }

	public virtual AstType get_Type() { }

}

