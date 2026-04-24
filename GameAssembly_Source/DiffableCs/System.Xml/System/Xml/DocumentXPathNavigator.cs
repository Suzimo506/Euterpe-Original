namespace System.Xml;

internal sealed class DocumentXPathNavigator : XPathNavigator, IHasXmlNode
{
	private XmlDocument document; //Field offset: 0x10
	private XmlNode source; //Field offset: 0x18
	private int attributeIndex; //Field offset: 0x20
	private XmlElement namespaceParent; //Field offset: 0x28

	public virtual string BaseURI
	{
		 get { } //Length: 39
	}

	public virtual string LocalName
	{
		 get { } //Length: 39
	}

	public virtual string Name
	{
		 get { } //Length: 396
	}

	public virtual string NamespaceURI
	{
		 get { } //Length: 174
	}

	public virtual XmlNameTable NameTable
	{
		 get { } //Length: 29
	}

	public virtual XPathNodeType NodeType
	{
		 get { } //Length: 110
	}

	public virtual string Prefix
	{
		 get { } //Length: 174
	}

	public virtual IXmlSchemaInfo SchemaInfo
	{
		 get { } //Length: 39
	}

	public virtual object UnderlyingObject
	{
		 get { } //Length: 84
	}

	public virtual string Value
	{
		 get { } //Length: 604
	}

	private string ValueDocument
	{
		private get { } //Length: 110
	}

	private string ValueText
	{
		private get { } //Length: 361
	}

	public virtual string XmlLang
	{
		 get { } //Length: 39
	}

	public DocumentXPathNavigator(XmlDocument document, XmlNode node) { }

	public DocumentXPathNavigator(DocumentXPathNavigator other) { }

	private void CalibrateText() { }

	private static bool CheckAttributePosition(XmlAttribute attribute, out XmlAttributeCollection attributes, int index) { }

	public virtual XPathNavigator Clone() { }

	private XmlNodeOrder Compare(XmlNode node1, XmlNode node2) { }

	public virtual XmlNodeOrder ComparePosition(XPathNavigator other) { }

	private XmlNode FirstChild(XmlNode node) { }

	private XmlNode FirstChildTail(XmlNode child) { }

	public virtual string get_BaseURI() { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	public virtual string get_NamespaceURI() { }

	public virtual XmlNameTable get_NameTable() { }

	public virtual XPathNodeType get_NodeType() { }

	public virtual string get_Prefix() { }

	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	public virtual object get_UnderlyingObject() { }

	public virtual string get_Value() { }

	private string get_ValueDocument() { }

	private string get_ValueText() { }

	public virtual string get_XmlLang() { }

	private static int GetDepth(XmlNode node) { }

	public virtual bool IsDescendant(XPathNavigator other) { }

	private static bool IsDescendant(XmlNode top, XmlNode bottom) { }

	public virtual bool IsSamePosition(XPathNavigator other) { }

	private static bool IsValidChild(XmlNode parent, XmlNode child) { }

	public virtual string LookupNamespace(string prefix) { }

	public virtual bool MoveTo(XPathNavigator other) { }

	public virtual bool MoveToAttribute(string localName, string namespaceURI) { }

	public virtual bool MoveToChild(string localName, string namespaceUri) { }

	public virtual bool MoveToChild(XPathNodeType type) { }

	public virtual bool MoveToFirstAttribute() { }

	public virtual bool MoveToFirstChild() { }

	public virtual bool MoveToFirstNamespace(XPathNamespaceScope scope) { }

	private static bool MoveToFirstNamespaceGlobal(ref XmlAttributeCollection attributes, ref int index) { }

	private static bool MoveToFirstNamespaceLocal(XmlAttributeCollection attributes, ref int index) { }

	public virtual bool MoveToFollowing(string localName, string namespaceUri, XPathNavigator end) { }

	public virtual bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	public virtual bool MoveToId(string id) { }

	public virtual bool MoveToNamespace(string name) { }

	public virtual bool MoveToNext(string localName, string namespaceUri) { }

	public virtual bool MoveToNext(XPathNodeType type) { }

	public virtual bool MoveToNext() { }

	public virtual bool MoveToNextAttribute() { }

	public virtual bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	private static bool MoveToNextNamespaceGlobal(ref XmlAttributeCollection attributes, ref int index) { }

	private static bool MoveToNextNamespaceLocal(XmlAttributeCollection attributes, ref int index) { }

	public virtual bool MoveToParent() { }

	public virtual void MoveToRoot() { }

	private XmlNode NextSibling(XmlNode node) { }

	private XmlNode NextSiblingTail(XmlNode node, XmlNode sibling) { }

	private static XmlNode OwnerNode(XmlNode node) { }

	private XmlNode ParentNode(XmlNode node) { }

	private XmlNode ParentNodeTail(XmlNode parent) { }

	private bool PathHasDuplicateNamespace(XmlElement top, XmlElement bottom, string localName) { }

	private XmlNode PreviousText(XmlNode node) { }

	private XmlNode PreviousTextTail(XmlNode node, XmlNode text) { }

	private static bool ResetAttributePosition(XmlAttribute attribute, XmlAttributeCollection attributes, out int index) { }

	internal void ResetPosition(XmlNode node) { }

	public virtual XPathNodeIterator SelectDescendants(string localName, string namespaceURI, bool matchSelf) { }

	public virtual XPathNodeIterator SelectDescendants(XPathNodeType nt, bool includeSelf) { }

	private override XmlNode System.Xml.IHasXmlNode.GetNode() { }

	private XmlNode TextEnd(XmlNode node) { }

}

