namespace MS.Internal.Xml.Cache;

internal class XPathDocumentElementChildIterator : XPathDocumentBaseIterator
{
	private string localName; //Field offset: 0x28
	private string namespaceUri; //Field offset: 0x30

	public XPathDocumentElementChildIterator(XPathDocumentNavigator parent, string name, string namespaceURI) { }

	public XPathDocumentElementChildIterator(XPathDocumentElementChildIterator iter) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual bool MoveNext() { }

}

