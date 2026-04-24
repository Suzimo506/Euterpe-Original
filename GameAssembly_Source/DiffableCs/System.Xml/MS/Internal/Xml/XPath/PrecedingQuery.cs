namespace MS.Internal.Xml.XPath;

internal sealed class PrecedingQuery : BaseAxisQuery
{
	private XPathNodeIterator workIterator; //Field offset: 0x58
	private ClonableStack<XPathNavigator> ancestorStk; //Field offset: 0x60

	public virtual QueryProps Properties
	{
		 get { } //Length: 6
	}

	public PrecedingQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	private PrecedingQuery(PrecedingQuery other) { }

	public virtual XPathNavigator Advance() { }

	public virtual XPathNodeIterator Clone() { }

	public virtual QueryProps get_Properties() { }

	public virtual void Reset() { }

}

