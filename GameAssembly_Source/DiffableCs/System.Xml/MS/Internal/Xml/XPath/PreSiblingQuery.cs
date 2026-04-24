namespace MS.Internal.Xml.XPath;

internal class PreSiblingQuery : CacheAxisQuery
{

	public virtual QueryProps Properties
	{
		 get { } //Length: 6
	}

	public PreSiblingQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	protected PreSiblingQuery(PreSiblingQuery other) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual object Evaluate(XPathNodeIterator context) { }

	public virtual QueryProps get_Properties() { }

	private bool NotVisited(XPathNavigator nav, List<XPathNavigator> parentStk) { }

}

