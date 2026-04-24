namespace MS.Internal.Xml.XPath;

internal sealed class ParentQuery : CacheAxisQuery
{

	public ParentQuery(Query qyInput, string Name, string Prefix, XPathNodeType Type) { }

	private ParentQuery(ParentQuery other) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual object Evaluate(XPathNodeIterator context) { }

}

