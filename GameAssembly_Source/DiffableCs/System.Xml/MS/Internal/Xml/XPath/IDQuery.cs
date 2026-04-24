namespace MS.Internal.Xml.XPath;

internal sealed class IDQuery : CacheOutputQuery
{

	public IDQuery(Query arg) { }

	private IDQuery(IDQuery other) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual object Evaluate(XPathNodeIterator context) { }

	private void ProcessIds(XPathNavigator contextNode, string val) { }

}

