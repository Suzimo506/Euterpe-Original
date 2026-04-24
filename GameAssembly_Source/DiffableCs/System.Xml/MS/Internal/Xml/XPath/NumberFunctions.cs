namespace MS.Internal.Xml.XPath;

internal sealed class NumberFunctions : ValueQuery
{
	private Query arg; //Field offset: 0x18
	private FunctionType ftype; //Field offset: 0x20

	public virtual XPathResultType StaticType
	{
		 get { } //Length: 3
	}

	public NumberFunctions(FunctionType ftype, Query arg) { }

	private NumberFunctions(NumberFunctions other) { }

	private double Ceiling(XPathNodeIterator nodeIterator) { }

	public virtual XPathNodeIterator Clone() { }

	public virtual object Evaluate(XPathNodeIterator nodeIterator) { }

	private double Floor(XPathNodeIterator nodeIterator) { }

	public virtual XPathResultType get_StaticType() { }

	internal static double Number(bool arg) { }

	internal static double Number(string arg) { }

	private double Number(XPathNodeIterator nodeIterator) { }

	private double Round(XPathNodeIterator nodeIterator) { }

	public virtual void SetXsltContext(XsltContext context) { }

	private double Sum(XPathNodeIterator nodeIterator) { }

}

