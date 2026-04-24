namespace System.Xml;

internal class DocumentXPathNodeIterator_ElemChildren_NoLocalName : DocumentXPathNodeIterator_ElemDescendants
{
	private string nsAtom; //Field offset: 0x28

	internal DocumentXPathNodeIterator_ElemChildren_NoLocalName(DocumentXPathNavigator nav, string nsAtom) { }

	internal DocumentXPathNodeIterator_ElemChildren_NoLocalName(DocumentXPathNodeIterator_ElemChildren_NoLocalName other) { }

	public virtual XPathNodeIterator Clone() { }

	protected virtual bool Match(XmlNode node) { }

}

