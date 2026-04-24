namespace System.Xml;

internal sealed class DocumentXPathNodeIterator_Empty : XPathNodeIterator
{
	private XPathNavigator nav; //Field offset: 0x18

	public virtual int Count
	{
		 get { } //Length: 3
	}

	public virtual XPathNavigator Current
	{
		 get { } //Length: 5
	}

	public virtual int CurrentPosition
	{
		 get { } //Length: 3
	}

	internal DocumentXPathNodeIterator_Empty(DocumentXPathNavigator nav) { }

	internal DocumentXPathNodeIterator_Empty(DocumentXPathNodeIterator_Empty other) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual int get_Count() { }

	public virtual XPathNavigator get_Current() { }

	public virtual int get_CurrentPosition() { }

	public virtual bool MoveNext() { }

}

