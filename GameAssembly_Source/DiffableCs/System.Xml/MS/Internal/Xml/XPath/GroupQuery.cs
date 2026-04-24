namespace MS.Internal.Xml.XPath;

internal sealed class GroupQuery : BaseAxisQuery
{

	public virtual QueryProps Properties
	{
		 get { } //Length: 6
	}

	public virtual XPathResultType StaticType
	{
		 get { } //Length: 39
	}

	public GroupQuery(Query qy) { }

	private GroupQuery(GroupQuery other) { }

	public virtual XPathNavigator Advance() { }

	public virtual XPathNodeIterator Clone() { }

	public virtual object Evaluate(XPathNodeIterator nodeIterator) { }

	public virtual QueryProps get_Properties() { }

	public virtual XPathResultType get_StaticType() { }

}

