namespace MS.Internal.Xml.XPath;

internal class ChildrenQuery : BaseAxisQuery
{
	private XPathNodeIterator iterator; //Field offset: 0x58

	public ChildrenQuery(Query qyInput, string name, string prefix, XPathNodeType type) { }

	protected ChildrenQuery(ChildrenQuery other) { }

	public virtual XPathNavigator Advance() { }

	public virtual XPathNodeIterator Clone() { }

	public virtual void Reset() { }

}

