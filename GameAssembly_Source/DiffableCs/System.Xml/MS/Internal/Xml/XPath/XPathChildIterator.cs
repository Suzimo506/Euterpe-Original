namespace MS.Internal.Xml.XPath;

internal class XPathChildIterator : XPathAxisIterator
{

	public XPathChildIterator(XPathNavigator nav, XPathNodeType type) { }

	public XPathChildIterator(XPathNavigator nav, string name, string namespaceURI) { }

	public XPathChildIterator(XPathChildIterator it) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual bool MoveNext() { }

}

