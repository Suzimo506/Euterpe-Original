namespace MS.Internal.Xml.XPath;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal abstract class Query : ResetableIterator
{

	public virtual int Count
	{
		 get { } //Length: 232
	}

	public override QueryProps Properties
	{
		 get { } //Length: 6
	}

	public abstract XPathResultType StaticType
	{
		 get { } //Length: 0
	}

	public Query() { }

	protected Query(Query other) { }

	public abstract XPathNavigator Advance() { }

	public static Query Clone(Query input) { }

	protected static XPathNodeIterator Clone(XPathNodeIterator input) { }

	protected static XPathNavigator Clone(XPathNavigator input) { }

	public static XmlNodeOrder CompareNodes(XPathNavigator l, XPathNavigator r) { }

	public abstract object Evaluate(XPathNodeIterator nodeIterator) { }

	public virtual int get_Count() { }

	public override QueryProps get_Properties() { }

	public abstract XPathResultType get_StaticType() { }

	private static int GetMedian(int l, int r) { }

	protected XPathResultType GetXPathType(object value) { }

	public bool Insert(List<XPathNavigator> buffer, XPathNavigator nav) { }

	public virtual bool MoveNext() { }

	public override void SetXsltContext(XsltContext context) { }

}

