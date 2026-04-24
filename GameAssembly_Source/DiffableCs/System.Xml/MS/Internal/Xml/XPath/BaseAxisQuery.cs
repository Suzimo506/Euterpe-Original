namespace MS.Internal.Xml.XPath;

internal abstract class BaseAxisQuery : Query
{
	internal Query qyInput; //Field offset: 0x18
	private bool nameTest; //Field offset: 0x20
	private string name; //Field offset: 0x28
	private string prefix; //Field offset: 0x30
	private string nsUri; //Field offset: 0x38
	private XPathNodeType typeTest; //Field offset: 0x40
	protected XPathNavigator currentNode; //Field offset: 0x48
	protected int position; //Field offset: 0x50

	public virtual XPathNavigator Current
	{
		 get { } //Length: 5
	}

	public virtual int CurrentPosition
	{
		 get { } //Length: 4
	}

	protected string Name
	{
		 get { } //Length: 5
	}

	protected string Namespace
	{
		 get { } //Length: 5
	}

	protected bool NameTest
	{
		 get { } //Length: 5
	}

	public virtual XPathResultType StaticType
	{
		 get { } //Length: 6
	}

	protected XPathNodeType TypeTest
	{
		 get { } //Length: 4
	}

	protected BaseAxisQuery(Query qyInput) { }

	protected BaseAxisQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	protected BaseAxisQuery(BaseAxisQuery other) { }

	public virtual object Evaluate(XPathNodeIterator nodeIterator) { }

	public virtual XPathNavigator get_Current() { }

	public virtual int get_CurrentPosition() { }

	protected string get_Name() { }

	protected string get_Namespace() { }

	protected bool get_NameTest() { }

	public virtual XPathResultType get_StaticType() { }

	protected XPathNodeType get_TypeTest() { }

	public override bool matches(XPathNavigator e) { }

	public virtual void Reset() { }

	public virtual void SetXsltContext(XsltContext context) { }

}

