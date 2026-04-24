namespace System.Xml;

internal abstract class DocumentXPathNodeIterator_ElemDescendants : XPathNodeIterator
{
	private DocumentXPathNavigator nav; //Field offset: 0x18
	private int level; //Field offset: 0x20
	private int position; //Field offset: 0x24

	public virtual XPathNavigator Current
	{
		 get { } //Length: 5
	}

	public virtual int CurrentPosition
	{
		 get { } //Length: 4
	}

	internal DocumentXPathNodeIterator_ElemDescendants(DocumentXPathNavigator nav) { }

	internal DocumentXPathNodeIterator_ElemDescendants(DocumentXPathNodeIterator_ElemDescendants other) { }

	public virtual XPathNavigator get_Current() { }

	public virtual int get_CurrentPosition() { }

	protected abstract bool Match(XmlNode node) { }

	public virtual bool MoveNext() { }

	protected void SetPosition(int pos) { }

}

