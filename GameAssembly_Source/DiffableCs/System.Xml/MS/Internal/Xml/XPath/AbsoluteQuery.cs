namespace MS.Internal.Xml.XPath;

internal sealed class AbsoluteQuery : ContextQuery
{

	public AbsoluteQuery() { }

	private AbsoluteQuery(AbsoluteQuery other) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual object Evaluate(XPathNodeIterator context) { }

}

