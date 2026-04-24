namespace MS.Internal.Xml.XPath;

internal sealed class NamespaceQuery : BaseAxisQuery
{
	private bool onNamespace; //Field offset: 0x58

	public NamespaceQuery(Query qyParent, string Name, string Prefix, XPathNodeType Type) { }

	private NamespaceQuery(NamespaceQuery other) { }

	public virtual XPathNavigator Advance() { }

	public virtual XPathNodeIterator Clone() { }

	public virtual bool matches(XPathNavigator e) { }

	public virtual void Reset() { }

}

