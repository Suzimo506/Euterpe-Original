namespace MS.Internal.Xml.XPath;

internal sealed class NodeFunctions : ValueQuery
{
	private Query arg; //Field offset: 0x18
	private FunctionType funcType; //Field offset: 0x20
	private XsltContext xsltContext; //Field offset: 0x28

	public virtual XPathResultType StaticType
	{
		 get { } //Length: 131
	}

	public NodeFunctions(FunctionType funcType, Query arg) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual object Evaluate(XPathNodeIterator context) { }

	private XPathNavigator EvaluateArg(XPathNodeIterator context) { }

	public virtual XPathResultType get_StaticType() { }

	public virtual void SetXsltContext(XsltContext context) { }

}

