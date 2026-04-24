namespace MS.Internal.Xml.Cache;

internal class XPathDocumentElementDescendantIterator : XPathDocumentBaseIterator
{
	private XPathDocumentNavigator end; //Field offset: 0x28
	private string localName; //Field offset: 0x30
	private string namespaceUri; //Field offset: 0x38
	private bool matchSelf; //Field offset: 0x40

	public XPathDocumentElementDescendantIterator(XPathDocumentNavigator root, string name, string namespaceURI, bool matchSelf) { }

	public XPathDocumentElementDescendantIterator(XPathDocumentElementDescendantIterator iter) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual bool MoveNext() { }

}

