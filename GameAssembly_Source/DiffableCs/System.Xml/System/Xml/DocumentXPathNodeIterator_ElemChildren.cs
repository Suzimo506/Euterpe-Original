namespace System.Xml;

internal class DocumentXPathNodeIterator_ElemChildren : DocumentXPathNodeIterator_ElemDescendants
{
	protected string localNameAtom; //Field offset: 0x28
	protected string nsAtom; //Field offset: 0x30

	internal DocumentXPathNodeIterator_ElemChildren(DocumentXPathNavigator nav, string localNameAtom, string nsAtom) { }

	internal DocumentXPathNodeIterator_ElemChildren(DocumentXPathNodeIterator_ElemChildren other) { }

	public virtual XPathNodeIterator Clone() { }

	protected virtual bool Match(XmlNode node) { }

}

