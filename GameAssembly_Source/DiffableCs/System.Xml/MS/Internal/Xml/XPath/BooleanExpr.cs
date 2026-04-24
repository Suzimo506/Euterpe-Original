namespace MS.Internal.Xml.XPath;

internal sealed class BooleanExpr : ValueQuery
{
	private Query opnd1; //Field offset: 0x18
	private Query opnd2; //Field offset: 0x20
	private bool isOr; //Field offset: 0x28

	public virtual XPathResultType StaticType
	{
		 get { } //Length: 6
	}

	public BooleanExpr(Op op, Query opnd1, Query opnd2) { }

	private BooleanExpr(BooleanExpr other) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual object Evaluate(XPathNodeIterator nodeIterator) { }

	public virtual XPathResultType get_StaticType() { }

	public virtual void SetXsltContext(XsltContext context) { }

}

