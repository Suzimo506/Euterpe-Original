namespace MS.Internal.Xml.XPath;

internal sealed class XPathAncestorQuery : CacheAxisQuery
{
	private bool matchSelf; //Field offset: 0x60

	public virtual int CurrentPosition
	{
		 get { } //Length: 64
	}

	public virtual QueryProps Properties
	{
		 get { } //Length: 6
	}

	public XPathAncestorQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest, bool matchSelf) { }

	private XPathAncestorQuery(XPathAncestorQuery other) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual object Evaluate(XPathNodeIterator context) { }

	public virtual int get_CurrentPosition() { }

	public virtual QueryProps get_Properties() { }

}

