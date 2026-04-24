namespace MS.Internal.Xml.XPath;

internal abstract class DescendantBaseQuery : BaseAxisQuery
{
	protected bool matchSelf; //Field offset: 0x58
	protected bool abbrAxis; //Field offset: 0x59

	public DescendantBaseQuery(Query qyParent, string Name, string Prefix, XPathNodeType Type, bool matchSelf, bool abbrAxis) { }

	public DescendantBaseQuery(DescendantBaseQuery other) { }

}

