namespace MS.Internal.Xml.XPath;

internal sealed class XPathSelfQuery : BaseAxisQuery
{

	public XPathSelfQuery(Query qyInput, string Name, string Prefix, XPathNodeType Type) { }

	private XPathSelfQuery(XPathSelfQuery other) { }

	public virtual XPathNavigator Advance() { }

	public virtual XPathNodeIterator Clone() { }

}

