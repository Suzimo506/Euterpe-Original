namespace MS.Internal.Xml.XPath;

internal sealed class VariableQuery : ExtensionQuery
{
	private IXsltContextVariable variable; //Field offset: 0x38

	public virtual XPathResultType StaticType
	{
		 get { } //Length: 94
	}

	public VariableQuery(string name, string prefix) { }

	private VariableQuery(VariableQuery other) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual object Evaluate(XPathNodeIterator nodeIterator) { }

	public virtual XPathResultType get_StaticType() { }

	public virtual void SetXsltContext(XsltContext context) { }

}

