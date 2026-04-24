namespace MS.Internal.Xml.Cache;

internal sealed class XPathDocumentNavigator : XPathNavigator, IXmlLineInfo
{
	private XPathNode[] pageCurrent; //Field offset: 0x10
	private XPathNode[] pageParent; //Field offset: 0x18
	private int idxCurrent; //Field offset: 0x20
	private int idxParent; //Field offset: 0x24
	private string atomizedLocalName; //Field offset: 0x28

	public virtual string BaseURI
	{
		 get { } //Length: 217
	}

	public override int LineNumber
	{
		 get { } //Length: 149
	}

	public override int LinePosition
	{
		 get { } //Length: 177
	}

	public virtual string LocalName
	{
		 get { } //Length: 68
	}

	public virtual string Name
	{
		 get { } //Length: 146
	}

	public virtual string NamespaceURI
	{
		 get { } //Length: 68
	}

	public virtual XmlNameTable NameTable
	{
		 get { } //Length: 77
	}

	public virtual XPathNodeType NodeType
	{
		 get { } //Length: 59
	}

	public virtual string Prefix
	{
		 get { } //Length: 68
	}

	public virtual object UnderlyingObject
	{
		 get { } //Length: 17
	}

	public virtual string Value
	{
		 get { } //Length: 818
	}

	public XPathDocumentNavigator(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent) { }

	public XPathDocumentNavigator(XPathDocumentNavigator nav) { }

	public virtual XPathNavigator Clone() { }

	public virtual XmlNodeOrder ComparePosition(XPathNavigator other) { }

	public virtual string get_BaseURI() { }

	public override int get_LineNumber() { }

	public override int get_LinePosition() { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	public virtual string get_NamespaceURI() { }

	public virtual XmlNameTable get_NameTable() { }

	public virtual XPathNodeType get_NodeType() { }

	public virtual string get_Prefix() { }

	public virtual object get_UnderlyingObject() { }

	public virtual string get_Value() { }

	private int GetFollowingEnd(XPathDocumentNavigator end, bool useParentOfVirtual, out XPathNode[] pageEnd) { }

	public int GetPositionHashCode() { }

	private int GetPrimaryLocation() { }

	private int GetSecondaryLocation() { }

	public override bool HasLineInfo() { }

	public virtual bool IsDescendant(XPathNavigator other) { }

	public bool IsElementMatch(string localName, string namespaceURI) { }

	public bool IsKindMatch(XPathNodeType typ) { }

	public virtual bool IsSamePosition(XPathNavigator other) { }

	public virtual bool MoveTo(XPathNavigator other) { }

	public virtual bool MoveToAttribute(string localName, string namespaceURI) { }

	public virtual bool MoveToChild(string localName, string namespaceURI) { }

	public virtual bool MoveToChild(XPathNodeType type) { }

	public virtual bool MoveToFirstAttribute() { }

	public virtual bool MoveToFirstChild() { }

	public virtual bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	public virtual bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	public virtual bool MoveToFollowing(string localName, string namespaceURI, XPathNavigator end) { }

	public virtual bool MoveToId(string id) { }

	public virtual bool MoveToNext() { }

	public virtual bool MoveToNext(XPathNodeType type) { }

	public virtual bool MoveToNext(string localName, string namespaceURI) { }

	public virtual bool MoveToNextAttribute() { }

	public virtual bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	public virtual bool MoveToParent() { }

	public virtual void MoveToRoot() { }

	public virtual XPathNodeIterator SelectChildren(XPathNodeType type) { }

	public virtual XPathNodeIterator SelectChildren(string name, string namespaceURI) { }

	public virtual XPathNodeIterator SelectDescendants(XPathNodeType type, bool matchSelf) { }

	public virtual XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf) { }

}

