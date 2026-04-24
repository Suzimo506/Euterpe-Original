namespace MS.Internal.Xml.XPath;

internal class XPathSelectionIterator : ResetableIterator
{
	private XPathNavigator nav; //Field offset: 0x18
	private Query query; //Field offset: 0x20
	private int position; //Field offset: 0x28

	public virtual int Count
	{
		 get { } //Length: 39
	}

	public virtual XPathNavigator Current
	{
		 get { } //Length: 5
	}

	public virtual int CurrentPosition
	{
		 get { } //Length: 4
	}

	internal XPathSelectionIterator(XPathNavigator nav, Query query) { }

	protected XPathSelectionIterator(XPathSelectionIterator it) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual int get_Count() { }

	public virtual XPathNavigator get_Current() { }

	public virtual int get_CurrentPosition() { }

	public virtual bool MoveNext() { }

	public virtual void Reset() { }

}

