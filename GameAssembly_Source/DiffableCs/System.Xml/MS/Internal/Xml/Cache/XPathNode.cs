namespace MS.Internal.Xml.Cache;

internal struct XPathNode
{
	private XPathNodeInfoAtom info; //Field offset: 0x0
	private ushort idxSibling; //Field offset: 0x8
	private ushort idxParent; //Field offset: 0xA
	private ushort idxSimilar; //Field offset: 0xC
	private ushort posOffset; //Field offset: 0xE
	private uint props; //Field offset: 0x10
	private string value; //Field offset: 0x18

	public string BaseUri
	{
		 get { } //Length: 26
	}

	public int CollapsedLinePosition
	{
		 get { } //Length: 35
	}

	public XPathDocument Document
	{
		 get { } //Length: 26
	}

	public bool HasAttribute
	{
		 get { } //Length: 8
	}

	public bool HasCollapsedText
	{
		 get { } //Length: 11
	}

	public bool HasContentChild
	{
		 get { } //Length: 8
	}

	public bool HasElementChild
	{
		 get { } //Length: 8
	}

	public bool HasNamespaceDecls
	{
		 get { } //Length: 11
	}

	public bool HasSibling
	{
		 get { } //Length: 9
	}

	public bool IsAttrNmsp
	{
		 get { } //Length: 21
	}

	public bool IsText
	{
		 get { } //Length: 86
	}

	public bool IsXmlNamespaceNode
	{
		 get { } //Length: 102
	}

	public int LineNumber
	{
		 get { } //Length: 36
	}

	public int LinePosition
	{
		 get { } //Length: 29
	}

	public string LocalName
	{
		 get { } //Length: 26
	}

	public string Name
	{
		 get { } //Length: 98
	}

	public string NamespaceUri
	{
		 get { } //Length: 26
	}

	public XPathNodeType NodeType
	{
		 get { } //Length: 7
	}

	public XPathNodePageInfo PageInfo
	{
		 get { } //Length: 26
	}

	public string Prefix
	{
		 get { } //Length: 26
	}

	public string Value
	{
		 get { } //Length: 5
	}

	public bool ElementMatch(string localName, string namespaceName) { }

	public string get_BaseUri() { }

	public int get_CollapsedLinePosition() { }

	public XPathDocument get_Document() { }

	public bool get_HasAttribute() { }

	public bool get_HasCollapsedText() { }

	public bool get_HasContentChild() { }

	public bool get_HasElementChild() { }

	public bool get_HasNamespaceDecls() { }

	public bool get_HasSibling() { }

	public bool get_IsAttrNmsp() { }

	public bool get_IsText() { }

	public bool get_IsXmlNamespaceNode() { }

	public int get_LineNumber() { }

	public int get_LinePosition() { }

	public string get_LocalName() { }

	public string get_Name() { }

	public string get_NamespaceUri() { }

	public XPathNodeType get_NodeType() { }

	public XPathNodePageInfo get_PageInfo() { }

	public string get_Prefix() { }

	public string get_Value() { }

	public int GetParent(out XPathNode[] pageNode) { }

	public int GetRoot(out XPathNode[] pageNode) { }

	public int GetSibling(out XPathNode[] pageNode) { }

	public int GetSimilarElement(out XPathNode[] pageNode) { }

	public bool NameMatch(string localName, string namespaceName) { }

}

