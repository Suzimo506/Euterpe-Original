namespace MS.Internal.Xml.XPath;

internal class XPathSingletonIterator : ResetableIterator
{
	private XPathNavigator nav; //Field offset: 0x18
	private int position; //Field offset: 0x20

	public virtual int Count
	{
		 get { } //Length: 6
	}

	public virtual XPathNavigator Current
	{
		 get { } //Length: 5
	}

	public virtual int CurrentPosition
	{
		 get { } //Length: 4
	}

	public XPathSingletonIterator(XPathNavigator nav) { }

	public XPathSingletonIterator(XPathNavigator nav, bool moved) { }

	public XPathSingletonIterator(XPathSingletonIterator it) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual int get_Count() { }

	public virtual XPathNavigator get_Current() { }

	public virtual int get_CurrentPosition() { }

	public virtual bool MoveNext() { }

	public virtual void Reset() { }

}

