namespace MS.Internal.Xml.XPath;

internal sealed class FilterQuery : BaseAxisQuery
{
	private Query cond; //Field offset: 0x58
	private bool noPosition; //Field offset: 0x60

	public Query Condition
	{
		 get { } //Length: 5
	}

	public virtual QueryProps Properties
	{
		 get { } //Length: 45
	}

	public FilterQuery(Query qyParent, Query cond, bool noPosition) { }

	private FilterQuery(FilterQuery other) { }

	public virtual XPathNavigator Advance() { }

	public virtual XPathNodeIterator Clone() { }

	internal bool EvaluatePredicate() { }

	public Query get_Condition() { }

	public virtual QueryProps get_Properties() { }

	public virtual void Reset() { }

	public virtual void SetXsltContext(XsltContext input) { }

}

