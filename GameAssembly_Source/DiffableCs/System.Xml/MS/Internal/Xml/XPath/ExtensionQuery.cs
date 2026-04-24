namespace MS.Internal.Xml.XPath;

internal abstract class ExtensionQuery : Query
{
	protected string prefix; //Field offset: 0x18
	protected string name; //Field offset: 0x20
	protected XsltContext xsltContext; //Field offset: 0x28
	private ResetableIterator queryIterator; //Field offset: 0x30

	public virtual int Count
	{
		 get { } //Length: 32
	}

	public virtual XPathNavigator Current
	{
		 get { } //Length: 150
	}

	public virtual int CurrentPosition
	{
		 get { } //Length: 29
	}

	protected string QName
	{
		 get { } //Length: 89
	}

	public virtual XPathResultType StaticType
	{
		 get { } //Length: 6
	}

	public ExtensionQuery(string prefix, string name) { }

	protected ExtensionQuery(ExtensionQuery other) { }

	public virtual XPathNavigator Advance() { }

	public virtual int get_Count() { }

	public virtual XPathNavigator get_Current() { }

	public virtual int get_CurrentPosition() { }

	protected string get_QName() { }

	public virtual XPathResultType get_StaticType() { }

	protected object ProcessResult(object value) { }

	public virtual void Reset() { }

}

