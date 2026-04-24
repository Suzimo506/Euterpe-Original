namespace MS.Internal.Xml.XPath;

internal sealed class UnionExpr : Query
{
	internal Query qy1; //Field offset: 0x18
	internal Query qy2; //Field offset: 0x20
	private bool advance1; //Field offset: 0x28
	private bool advance2; //Field offset: 0x29
	private XPathNavigator currentNode; //Field offset: 0x30
	private XPathNavigator nextNode; //Field offset: 0x38

	public virtual XPathNavigator Current
	{
		 get { } //Length: 5
	}

	public virtual int CurrentPosition
	{
		 get { } //Length: 73
	}

	public virtual XPathResultType StaticType
	{
		 get { } //Length: 6
	}

	public UnionExpr(Query query1, Query query2) { }

	private UnionExpr(UnionExpr other) { }

	public virtual XPathNavigator Advance() { }

	public virtual XPathNodeIterator Clone() { }

	public virtual object Evaluate(XPathNodeIterator context) { }

	public virtual XPathNavigator get_Current() { }

	public virtual int get_CurrentPosition() { }

	public virtual XPathResultType get_StaticType() { }

	private XPathNavigator ProcessAfterPosition(XPathNavigator res1, XPathNavigator res2) { }

	private XPathNavigator ProcessBeforePosition(XPathNavigator res1, XPathNavigator res2) { }

	private XPathNavigator ProcessSamePosition(XPathNavigator result) { }

	public virtual void Reset() { }

	public virtual void SetXsltContext(XsltContext xsltContext) { }

}

