namespace MS.Internal.Xml.XPath;

internal sealed class FollSiblingQuery : BaseAxisQuery
{
	private ClonableStack<XPathNavigator> elementStk; //Field offset: 0x58
	private List<XPathNavigator> parentStk; //Field offset: 0x60
	private XPathNavigator nextInput; //Field offset: 0x68

	public FollSiblingQuery(Query qyInput, string name, string prefix, XPathNodeType type) { }

	private FollSiblingQuery(FollSiblingQuery other) { }

	public virtual XPathNavigator Advance() { }

	public virtual XPathNodeIterator Clone() { }

	private XPathNavigator FetchInput() { }

	public virtual void Reset() { }

	private bool Visited(XPathNavigator nav) { }

}

