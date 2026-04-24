namespace MS.Internal.Xml.XPath;

internal class XPathDescendantIterator : XPathAxisIterator
{
	private int level; //Field offset: 0x40

	public XPathDescendantIterator(XPathNavigator nav, XPathNodeType type, bool matchSelf) { }

	public XPathDescendantIterator(XPathNavigator nav, string name, string namespaceURI, bool matchSelf) { }

	public XPathDescendantIterator(XPathDescendantIterator it) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual bool MoveNext() { }

}

