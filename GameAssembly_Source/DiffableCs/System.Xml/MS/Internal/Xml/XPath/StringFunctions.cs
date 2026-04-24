namespace MS.Internal.Xml.XPath;

internal sealed class StringFunctions : ValueQuery
{
	private static readonly CompareInfo compareInfo; //Field offset: 0x0
	private FunctionType funcType; //Field offset: 0x18
	private IList<Query> argList; //Field offset: 0x20

	public virtual XPathResultType StaticType
	{
		 get { } //Length: 22
	}

	private static StringFunctions() { }

	public StringFunctions(FunctionType funcType, IList<Query> argList) { }

	private StringFunctions(StringFunctions other) { }

	public virtual XPathNodeIterator Clone() { }

	private string Concat(XPathNodeIterator nodeIterator) { }

	private bool Contains(XPathNodeIterator nodeIterator) { }

	public virtual object Evaluate(XPathNodeIterator nodeIterator) { }

	public virtual XPathResultType get_StaticType() { }

	private string Normalize(XPathNodeIterator nodeIterator) { }

	public virtual void SetXsltContext(XsltContext context) { }

	private bool StartsWith(XPathNodeIterator nodeIterator) { }

	private double StringLength(XPathNodeIterator nodeIterator) { }

	private string Substring(XPathNodeIterator nodeIterator) { }

	private string SubstringAfter(XPathNodeIterator nodeIterator) { }

	private string SubstringBefore(XPathNodeIterator nodeIterator) { }

	internal static string toString(bool b) { }

	internal static string toString(double num) { }

	private string toString(XPathNodeIterator nodeIterator) { }

	private string Translate(XPathNodeIterator nodeIterator) { }

}

