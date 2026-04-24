namespace MS.Internal.Xml.XPath;

internal sealed class DocumentOrderQuery : CacheOutputQuery
{

	public DocumentOrderQuery(Query qyParent) { }

	private DocumentOrderQuery(DocumentOrderQuery other) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual object Evaluate(XPathNodeIterator context) { }

}

