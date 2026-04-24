namespace MS.Internal.Xml.XPath;

internal class DescendantQuery : DescendantBaseQuery
{
	private XPathNodeIterator nodeIterator; //Field offset: 0x60

	internal DescendantQuery(Query qyParent, string Name, string Prefix, XPathNodeType Type, bool matchSelf, bool abbrAxis) { }

	public DescendantQuery(DescendantQuery other) { }

	public virtual XPathNavigator Advance() { }

	public virtual XPathNodeIterator Clone() { }

	public virtual void Reset() { }

}

