namespace MS.Internal.Xml.XPath;

internal sealed class MergeFilterQuery : CacheOutputQuery
{
	private Query child; //Field offset: 0x28

	public MergeFilterQuery(Query input, Query child) { }

	private MergeFilterQuery(MergeFilterQuery other) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual object Evaluate(XPathNodeIterator nodeIterator) { }

	public virtual void SetXsltContext(XsltContext xsltContext) { }

}

