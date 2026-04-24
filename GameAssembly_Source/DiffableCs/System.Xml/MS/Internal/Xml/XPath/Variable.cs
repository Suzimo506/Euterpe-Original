namespace MS.Internal.Xml.XPath;

internal class Variable : AstNode
{
	private string localname; //Field offset: 0x10
	private string prefix; //Field offset: 0x18

	public string Localname
	{
		 get { } //Length: 5
	}

	public string Prefix
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

	public Variable(string name, string prefix) { }

	public string get_Localname() { }

	public string get_Prefix() { }

	public virtual XPathResultType get_ReturnType() { }

	public virtual AstType get_Type() { }

}

