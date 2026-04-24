namespace MS.Internal.Xml.Cache;

internal abstract class XPathDocumentBaseIterator : XPathNodeIterator
{
	protected XPathDocumentNavigator ctxt; //Field offset: 0x18
	protected int pos; //Field offset: 0x20

	public virtual XPathNavigator Current
	{
		 get { } //Length: 5
	}

	public virtual int CurrentPosition
	{
		 get { } //Length: 4
	}

	protected XPathDocumentBaseIterator(XPathDocumentNavigator ctxt) { }

	protected XPathDocumentBaseIterator(XPathDocumentBaseIterator iter) { }

	public virtual XPathNavigator get_Current() { }

	public virtual int get_CurrentPosition() { }

}

