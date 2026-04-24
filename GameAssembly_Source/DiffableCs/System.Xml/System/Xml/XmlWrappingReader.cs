namespace System.Xml;

internal class XmlWrappingReader : XmlReader, IXmlLineInfo
{
	protected XmlReader reader; //Field offset: 0x10
	protected IXmlLineInfo readerAsIXmlLineInfo; //Field offset: 0x18

	public virtual int AttributeCount
	{
		 get { } //Length: 39
	}

	public virtual string BaseURI
	{
		 get { } //Length: 39
	}

	public virtual bool CanResolveEntity
	{
		 get { } //Length: 39
	}

	public virtual int Depth
	{
		 get { } //Length: 39
	}

	internal virtual IDtdInfo DtdInfo
	{
		internal get { } //Length: 39
	}

	public virtual bool EOF
	{
		 get { } //Length: 39
	}

	public virtual bool HasAttributes
	{
		 get { } //Length: 39
	}

	public virtual bool HasValue
	{
		 get { } //Length: 39
	}

	public virtual bool IsDefault
	{
		 get { } //Length: 39
	}

	public virtual bool IsEmptyElement
	{
		 get { } //Length: 39
	}

	public override int LineNumber
	{
		 get { } //Length: 75
	}

	public override int LinePosition
	{
		 get { } //Length: 75
	}

	public virtual string LocalName
	{
		 get { } //Length: 39
	}

	public virtual string Name
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

	public virtual char QuoteChar
	{
		 get { } //Length: 39
	}

	public virtual ReadState ReadState
	{
		 get { } //Length: 39
	}

	public virtual IXmlSchemaInfo SchemaInfo
	{
		 get { } //Length: 39
	}

	public virtual XmlReaderSettings Settings
	{
		 get { } //Length: 39
	}

	public virtual string Value
	{
		 get { } //Length: 39
	}

	public virtual Type ValueType
	{
		 get { } //Length: 39
	}

	public virtual string XmlLang
	{
		 get { } //Length: 39
	}

	public virtual XmlSpace XmlSpace
	{
		 get { } //Length: 39
	}

	internal XmlWrappingReader(XmlReader baseReader) { }

	public virtual void Close() { }

	public virtual int get_AttributeCount() { }

	public virtual string get_BaseURI() { }

	public virtual bool get_CanResolveEntity() { }

	public virtual int get_Depth() { }

	internal virtual IDtdInfo get_DtdInfo() { }

	public virtual bool get_EOF() { }

	public virtual bool get_HasAttributes() { }

	public virtual bool get_HasValue() { }

	public virtual bool get_IsDefault() { }

	public virtual bool get_IsEmptyElement() { }

	public override int get_LineNumber() { }

	public override int get_LinePosition() { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	public virtual string get_NamespaceURI() { }

	public virtual XmlNameTable get_NameTable() { }

	public virtual XmlNodeType get_NodeType() { }

	public virtual string get_Prefix() { }

	public virtual char get_QuoteChar() { }

	public virtual ReadState get_ReadState() { }

	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	public virtual XmlReaderSettings get_Settings() { }

	public virtual string get_Value() { }

	public virtual Type get_ValueType() { }

	public virtual string get_XmlLang() { }

	public virtual XmlSpace get_XmlSpace() { }

	public virtual string GetAttribute(string name) { }

	public virtual string GetAttribute(int i) { }

	public virtual string GetAttribute(string name, string namespaceURI) { }

	public override bool HasLineInfo() { }

	public virtual string LookupNamespace(string prefix) { }

	public virtual bool MoveToAttribute(string name) { }

	public virtual void MoveToAttribute(int i) { }

	public virtual bool MoveToElement() { }

	public virtual bool MoveToFirstAttribute() { }

	public virtual bool MoveToNextAttribute() { }

	public virtual bool Read() { }

	public virtual bool ReadAttributeValue() { }

	public virtual void ResolveEntity() { }

	public virtual void Skip() { }

}

