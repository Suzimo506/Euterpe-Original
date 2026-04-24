namespace MS.Internal.Xml.XPath;

internal class ContextQuery : Query
{
	protected XPathNavigator contextNode; //Field offset: 0x18

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

	public virtual QueryProps Properties
	{
		 get { } //Length: 6
	}

	public virtual XPathResultType StaticType
	{
		 get { } //Length: 6
	}

	public ContextQuery() { }

	protected ContextQuery(ContextQuery other) { }

	public virtual XPathNavigator Advance() { }

	public virtual XPathNodeIterator Clone() { }

	public virtual object Evaluate(XPathNodeIterator context) { }

	public virtual int get_Count() { }

	public virtual XPathNavigator get_Current() { }

	public virtual int get_CurrentPosition() { }

	public virtual QueryProps get_Properties() { }

	public virtual XPathResultType get_StaticType() { }

	public virtual void Reset() { }

}

