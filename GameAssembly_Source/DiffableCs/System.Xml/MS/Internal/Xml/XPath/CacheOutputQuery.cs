namespace MS.Internal.Xml.XPath;

internal abstract class CacheOutputQuery : Query
{
	internal Query input; //Field offset: 0x18
	protected List<XPathNavigator> outputBuffer; //Field offset: 0x20

	public virtual int Count
	{
		 get { } //Length: 59
	}

	public virtual XPathNavigator Current
	{
		 get { } //Length: 110
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

	public CacheOutputQuery(Query input) { }

	protected CacheOutputQuery(CacheOutputQuery other) { }

	public virtual XPathNavigator Advance() { }

	public virtual object Evaluate(XPathNodeIterator context) { }

	public virtual int get_Count() { }

	public virtual XPathNavigator get_Current() { }

	public virtual int get_CurrentPosition() { }

	public virtual QueryProps get_Properties() { }

	public virtual XPathResultType get_StaticType() { }

	public virtual void Reset() { }

	public virtual void SetXsltContext(XsltContext context) { }

}

