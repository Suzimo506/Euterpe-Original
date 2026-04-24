namespace MS.Internal.Xml.XPath;

internal sealed class AttributeQuery : BaseAxisQuery
{
	private bool onAttribute; //Field offset: 0x58

	public AttributeQuery(Query qyParent, string Name, string Prefix, XPathNodeType Type) { }

	private AttributeQuery(AttributeQuery other) { }

	public virtual XPathNavigator Advance() { }

	public virtual XPathNodeIterator Clone() { }

	public virtual void Reset() { }

}

