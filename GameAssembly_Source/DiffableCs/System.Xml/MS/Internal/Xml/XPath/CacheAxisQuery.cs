namespace MS.Internal.Xml.XPath;

internal abstract class CacheAxisQuery : BaseAxisQuery
{
	protected List<XPathNavigator> outputBuffer; //Field offset: 0x58

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

	public CacheAxisQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	protected CacheAxisQuery(CacheAxisQuery other) { }

	public virtual XPathNavigator Advance() { }

	public virtual object Evaluate(XPathNodeIterator context) { }

	public virtual int get_Count() { }

	public virtual XPathNavigator get_Current() { }

	public virtual int get_CurrentPosition() { }

	public virtual QueryProps get_Properties() { }

	public virtual void Reset() { }

}

