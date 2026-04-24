namespace MS.Internal.Xml.XPath;

internal class IteratorFilter : XPathNodeIterator
{
	private XPathNodeIterator innerIterator; //Field offset: 0x18
	private string name; //Field offset: 0x20
	private int position; //Field offset: 0x28

	public virtual XPathNavigator Current
	{
		 get { } //Length: 39
	}

	public virtual int CurrentPosition
	{
		 get { } //Length: 4
	}

	internal IteratorFilter(XPathNodeIterator innerIterator, string name) { }

	private IteratorFilter(IteratorFilter it) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual XPathNavigator get_Current() { }

	public virtual int get_CurrentPosition() { }

	public virtual bool MoveNext() { }

}

