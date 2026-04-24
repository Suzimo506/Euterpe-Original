namespace MS.Internal.Xml.XPath;

internal sealed class CacheChildrenQuery : ChildrenQuery
{
	private XPathNavigator nextInput; //Field offset: 0x60
	private ClonableStack<XPathNavigator> elementStk; //Field offset: 0x68
	private ClonableStack<Int32> positionStk; //Field offset: 0x70
	private bool needInput; //Field offset: 0x78

	public CacheChildrenQuery(Query qyInput, string name, string prefix, XPathNodeType type) { }

	private CacheChildrenQuery(CacheChildrenQuery other) { }

	public virtual XPathNavigator Advance() { }

	public virtual XPathNodeIterator Clone() { }

	private bool DecideNextNode() { }

	private XPathNavigator GetNextInput() { }

	public virtual void Reset() { }

}

