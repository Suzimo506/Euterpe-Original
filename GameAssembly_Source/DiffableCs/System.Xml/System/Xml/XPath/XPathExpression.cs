namespace System.Xml.XPath;

public abstract class XPathExpression
{

	internal XPathExpression() { }

	public static XPathExpression Compile(string xpath) { }

	public static XPathExpression Compile(string xpath, IXmlNamespaceResolver nsResolver) { }

	public abstract void SetContext(IXmlNamespaceResolver nsResolver) { }

}

