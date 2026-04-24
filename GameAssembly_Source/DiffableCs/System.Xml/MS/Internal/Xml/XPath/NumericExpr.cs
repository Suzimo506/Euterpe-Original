namespace MS.Internal.Xml.XPath;

internal sealed class NumericExpr : ValueQuery
{
	private Op op; //Field offset: 0x18
	private Query opnd1; //Field offset: 0x20
	private Query opnd2; //Field offset: 0x28

	public virtual XPathResultType StaticType
	{
		 get { } //Length: 3
	}

	public NumericExpr(Op op, Query opnd1, Query opnd2) { }

	private NumericExpr(NumericExpr other) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual object Evaluate(XPathNodeIterator nodeIterator) { }

	public virtual XPathResultType get_StaticType() { }

	private static double GetValue(Op op, double n1, double n2) { }

	public virtual void SetXsltContext(XsltContext context) { }

}

