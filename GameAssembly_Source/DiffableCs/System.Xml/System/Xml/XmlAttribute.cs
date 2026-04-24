namespace System.Xml;

public class XmlAttribute : XmlNode
{
	private XmlName name; //Field offset: 0x18
	private XmlLinkedNode lastChild; //Field offset: 0x20

	public virtual string BaseURI
	{
		 get { } //Length: 137
	}

	public virtual string InnerText
	{
		 set { } //Length: 109
	}

	public virtual string InnerXml
	{
		 set { } //Length: 134
	}

	internal virtual bool IsContainer
	{
		internal get { } //Length: 3
	}

	internal bool IsNamespace
	{
		internal get { } //Length: 50
	}

	internal virtual XmlLinkedNode LastNode
	{
		internal get { } //Length: 5
		internal set { } //Length: 12
	}

	public virtual string LocalName
	{
		 get { } //Length: 27
	}

	internal int LocalNameHash
	{
		internal get { } //Length: 26
	}

	public virtual string Name
	{
		 get { } //Length: 29
	}

	public virtual string NamespaceURI
	{
		 get { } //Length: 27
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 6
	}

	public virtual XmlDocument OwnerDocument
	{
		 get { } //Length: 27
	}

	public override XmlElement OwnerElement
	{
		 get { } //Length: 125
	}

	public virtual XmlNode ParentNode
	{
		 get { } //Length: 3
	}

	public virtual string Prefix
	{
		 get { } //Length: 27
		 set { } //Length: 190
	}

	public virtual IXmlSchemaInfo SchemaInfo
	{
		 get { } //Length: 5
	}

	public override bool Specified
	{
		 get { } //Length: 3
	}

	public virtual string Value
	{
		 get { } //Length: 17
		 set { } //Length: 17
	}

	internal virtual string XmlLang
	{
		internal get { } //Length: 137
	}

	internal XmlName XmlName
	{
		internal get { } //Length: 5
		internal set { } //Length: 12
	}

	internal virtual XmlSpace XmlSpace
	{
		internal get { } //Length: 90
	}

	internal virtual string XPLocalName
	{
		internal get { } //Length: 130
	}

	internal virtual XPathNodeType XPNodeType
	{
		internal get { } //Length: 61
	}

	internal XmlAttribute(XmlName name, XmlDocument doc) { }

	protected private XmlAttribute(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	public virtual XmlNode AppendChild(XmlNode newChild) { }

	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	public virtual XmlNode CloneNode(bool deep) { }

	public virtual string get_BaseURI() { }

	internal virtual bool get_IsContainer() { }

	internal bool get_IsNamespace() { }

	internal virtual XmlLinkedNode get_LastNode() { }

	public virtual string get_LocalName() { }

	internal int get_LocalNameHash() { }

	public virtual string get_Name() { }

	public virtual string get_NamespaceURI() { }

	public virtual XmlNodeType get_NodeType() { }

	public virtual XmlDocument get_OwnerDocument() { }

	public override XmlElement get_OwnerElement() { }

	public virtual XmlNode get_ParentNode() { }

	public virtual string get_Prefix() { }

	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	public override bool get_Specified() { }

	public virtual string get_Value() { }

	internal virtual string get_XmlLang() { }

	internal XmlName get_XmlName() { }

	internal virtual XmlSpace get_XmlSpace() { }

	internal virtual string get_XPLocalName() { }

	internal virtual XPathNodeType get_XPNodeType() { }

	public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	internal virtual bool IsValidChildType(XmlNodeType type) { }

	internal bool PrepareOwnerElementInElementIdAttrMap() { }

	public virtual XmlNode PrependChild(XmlNode newChild) { }

	public virtual XmlNode RemoveChild(XmlNode oldChild) { }

	internal void ResetOwnerElementInElementIdAttrMap(string oldInnerText) { }

	public virtual void set_InnerText(string value) { }

	public virtual void set_InnerXml(string value) { }

	internal virtual void set_LastNode(XmlLinkedNode value) { }

	public virtual void set_Prefix(string value) { }

	public virtual void set_Value(string value) { }

	internal void set_XmlName(XmlName value) { }

	internal virtual void SetParent(XmlNode node) { }

	public virtual void WriteContentTo(XmlWriter w) { }

	public virtual void WriteTo(XmlWriter w) { }

}

