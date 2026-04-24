namespace MS.Internal.Xml.XPath;

internal sealed class BooleanFunctions : ValueQuery
{
	private Query arg; //Field offset: 0x18
	private FunctionType funcType; //Field offset: 0x20

	public virtual XPathResultType StaticType
	{
		 get { } //Length: 6
	}

	public BooleanFunctions(FunctionType funcType, Query arg) { }

	private BooleanFunctions(BooleanFunctions other) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual object Evaluate(XPathNodeIterator nodeIterator) { }

	public virtual XPathResultType get_StaticType() { }

	private bool Lang(XPathNodeIterator nodeIterator) { }

	private bool Not(XPathNodeIterator nodeIterator) { }

	public virtual void SetXsltContext(XsltContext context) { }

	internal static bool toBoolean(double number) { }

	internal static bool toBoolean(string str) { }

	internal bool toBoolean(XPathNodeIterator nodeIterator) { }

}

