namespace MS.Internal.Xml.XPath;

internal sealed class XPathEmptyIterator : ResetableIterator
{
	public static XPathEmptyIterator Instance; //Field offset: 0x6B2D1

	public virtual int Count
	{
		 get { } //Length: 3
	}

	public virtual XPathNavigator Current
	{
		 get { } //Length: 3
	}

	public virtual int CurrentPosition
	{
		 get { } //Length: 3
	}

	private static XPathEmptyIterator() { }

	private XPathEmptyIterator() { }

	public virtual XPathNodeIterator Clone() { }

	public virtual int get_Count() { }

	public virtual XPathNavigator get_Current() { }

	public virtual int get_CurrentPosition() { }

	public virtual bool MoveNext() { }

	public virtual void Reset() { }

}

