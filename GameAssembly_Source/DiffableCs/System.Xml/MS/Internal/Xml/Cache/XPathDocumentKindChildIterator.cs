namespace MS.Internal.Xml.Cache;

internal class XPathDocumentKindChildIterator : XPathDocumentBaseIterator
{
	private XPathNodeType typ; //Field offset: 0x28

	public XPathDocumentKindChildIterator(XPathDocumentNavigator parent, XPathNodeType typ) { }

	public XPathDocumentKindChildIterator(XPathDocumentKindChildIterator iter) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual bool MoveNext() { }

}

