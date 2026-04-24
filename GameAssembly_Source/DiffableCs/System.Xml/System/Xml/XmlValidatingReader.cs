namespace System.Xml;

[Obsolete]
public class XmlValidatingReader : XmlReader
{
	private XmlValidatingReaderImpl impl; //Field offset: 0x10

	public virtual int AttributeCount
	{
		 get { } //Length: 39
	}

	public virtual string BaseURI
	{
		 get { } //Length: 39
	}

	public virtual int Depth
	{
		 get { } //Length: 39
	}

	public virtual bool EOF
	{
		 get { } //Length: 39
	}

	public virtual bool IsEmptyElement
	{
		 get { } //Length: 39
	}

	public virtual string LocalName
	{
		 get { } //Length: 39
	}

	public bool Namespaces
	{
		 get { } //Length: 39
	}

	public virtual string NamespaceURI
	{
		 get { } //Length: 39
	}

	public virtual XmlNameTable NameTable
	{
		 get { } //Length: 39
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 39
	}

	public virtual string Prefix
	{
		 get { } //Length: 39
	}

	public virtual ReadState ReadState
	{
		 get { } //Length: 39
	}

	public virtual string Value
	{
		 get { } //Length: 39
	}

	public virtual int get_AttributeCount() { }

	public virtual string get_BaseURI() { }

	public virtual int get_Depth() { }

	public virtual bool get_EOF() { }

	public virtual bool get_IsEmptyElement() { }

	public virtual string get_LocalName() { }

	public bool get_Namespaces() { }

	public virtual string get_NamespaceURI() { }

	public virtual XmlNameTable get_NameTable() { }

	public virtual XmlNodeType get_NodeType() { }

	public virtual string get_Prefix() { }

	public virtual ReadState get_ReadState() { }

	public virtual string get_Value() { }

	public virtual string GetAttribute(string localName, string namespaceURI) { }

	public virtual string GetAttribute(string name) { }

	public virtual string GetAttribute(int i) { }

	public virtual string LookupNamespace(string prefix) { }

	public virtual bool MoveToAttribute(string name) { }

	public virtual bool MoveToElement() { }

	public virtual bool MoveToFirstAttribute() { }

	public virtual bool MoveToNextAttribute() { }

	public virtual bool Read() { }

	public virtual bool ReadAttributeValue() { }

	public virtual void ResolveEntity() { }

}

