namespace MS.Internal.Xml.XPath;

internal sealed class FollowingQuery : BaseAxisQuery
{
	private XPathNavigator input; //Field offset: 0x58
	private XPathNodeIterator iterator; //Field offset: 0x60

	public FollowingQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	private FollowingQuery(FollowingQuery other) { }

	public virtual XPathNavigator Advance() { }

	public virtual XPathNodeIterator Clone() { }

	public virtual void Reset() { }

}

