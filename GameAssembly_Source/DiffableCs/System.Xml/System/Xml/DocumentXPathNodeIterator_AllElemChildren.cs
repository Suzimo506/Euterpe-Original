namespace System.Xml;

internal class DocumentXPathNodeIterator_AllElemChildren : DocumentXPathNodeIterator_ElemDescendants
{

	internal DocumentXPathNodeIterator_AllElemChildren(DocumentXPathNavigator nav) { }

	internal DocumentXPathNodeIterator_AllElemChildren(DocumentXPathNodeIterator_AllElemChildren other) { }

	public virtual XPathNodeIterator Clone() { }

	protected virtual bool Match(XmlNode node) { }

}

