namespace MS.Internal.Xml.Cache;

internal sealed class XPathNodeInfoAtom
{
	private string localName; //Field offset: 0x10
	private string namespaceUri; //Field offset: 0x18
	private string prefix; //Field offset: 0x20
	private string baseUri; //Field offset: 0x28
	private XPathNode[] pageParent; //Field offset: 0x30
	private XPathNode[] pageSibling; //Field offset: 0x38
	private XPathNode[] pageSimilar; //Field offset: 0x40
	private XPathDocument doc; //Field offset: 0x48
	private int lineNumBase; //Field offset: 0x50
	private int linePosBase; //Field offset: 0x54
	private XPathNodePageInfo pageInfo; //Field offset: 0x58

	public string BaseUri
	{
		 get { } //Length: 5
	}

	public XPathDocument Document
	{
		 get { } //Length: 5
	}

	public int LineNumberBase
	{
		 get { } //Length: 4
	}

	public int LinePositionBase
	{
		 get { } //Length: 4
	}

	public string LocalName
	{
		 get { } //Length: 5
	}

	public string NamespaceUri
	{
		 get { } //Length: 5
	}

	public XPathNodePageInfo PageInfo
	{
		 get { } //Length: 5
	}

	public XPathNode[] ParentPage
	{
		 get { } //Length: 5
	}

	public string Prefix
	{
		 get { } //Length: 5
	}

	public XPathNode[] SiblingPage
	{
		 get { } //Length: 5
	}

	public XPathNode[] SimilarElementPage
	{
		 get { } //Length: 5
	}

	public string get_BaseUri() { }

	public XPathDocument get_Document() { }

	public int get_LineNumberBase() { }

	public int get_LinePositionBase() { }

	public string get_LocalName() { }

	public string get_NamespaceUri() { }

	public XPathNodePageInfo get_PageInfo() { }

	public XPathNode[] get_ParentPage() { }

	public string get_Prefix() { }

	public XPathNode[] get_SiblingPage() { }

	public XPathNode[] get_SimilarElementPage() { }

}

