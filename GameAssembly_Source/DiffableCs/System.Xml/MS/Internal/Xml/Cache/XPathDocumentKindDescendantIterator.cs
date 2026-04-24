namespace MS.Internal.Xml.Cache;

internal class XPathDocumentKindDescendantIterator : XPathDocumentBaseIterator
{
	private XPathDocumentNavigator end; //Field offset: 0x28
	private XPathNodeType typ; //Field offset: 0x30
	private bool matchSelf; //Field offset: 0x34

	public XPathDocumentKindDescendantIterator(XPathDocumentNavigator root, XPathNodeType typ, bool matchSelf) { }

	public XPathDocumentKindDescendantIterator(XPathDocumentKindDescendantIterator iter) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual bool MoveNext() { }

}

