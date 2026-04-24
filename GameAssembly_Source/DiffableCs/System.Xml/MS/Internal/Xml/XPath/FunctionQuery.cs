namespace MS.Internal.Xml.XPath;

internal sealed class FunctionQuery : ExtensionQuery
{
	private IList<Query> args; //Field offset: 0x38
	private IXsltContextFunction function; //Field offset: 0x40

	public virtual XPathResultType StaticType
	{
		 get { } //Length: 90
	}

	public FunctionQuery(string prefix, string name, List<Query> args) { }

	private FunctionQuery(FunctionQuery other) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual object Evaluate(XPathNodeIterator nodeIterator) { }

	public virtual XPathResultType get_StaticType() { }

	public virtual void SetXsltContext(XsltContext context) { }

}

