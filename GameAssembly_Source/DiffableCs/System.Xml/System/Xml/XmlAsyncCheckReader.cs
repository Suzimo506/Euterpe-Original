namespace System.Xml;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class XmlAsyncCheckReader : XmlReader
{
	private readonly XmlReader coreReader; //Field offset: 0x10
	private Task lastTask; //Field offset: 0x18

	public virtual int AttributeCount
	{
		 get { } //Length: 52
	}

	public virtual string BaseURI
	{
		 get { } //Length: 52
	}

	public virtual bool CanReadBinaryContent
	{
		 get { } //Length: 52
	}

	public virtual bool CanReadValueChunk
	{
		 get { } //Length: 52
	}

	public virtual bool CanResolveEntity
	{
		 get { } //Length: 52
	}

	internal XmlReader CoreReader
	{
		internal get { } //Length: 5
	}

	public virtual int Depth
	{
		 get { } //Length: 52
	}

	internal virtual IDtdInfo DtdInfo
	{
		internal get { } //Length: 52
	}

	public virtual bool EOF
	{
		 get { } //Length: 52
	}

	public virtual bool HasAttributes
	{
		 get { } //Length: 52
	}

	public virtual bool HasValue
	{
		 get { } //Length: 52
	}

	public virtual bool IsDefault
	{
		 get { } //Length: 52
	}

	public virtual bool IsEmptyElement
	{
		 get { } //Length: 52
	}

	public virtual string LocalName
	{
		 get { } //Length: 52
	}

	public virtual string Name
	{
		 get { } //Length: 52
	}

	internal virtual XmlNamespaceManager NamespaceManager
	{
		internal get { } //Length: 52
	}

	public virtual string NamespaceURI
	{
		 get { } //Length: 52
	}

	public virtual XmlNameTable NameTable
	{
		 get { } //Length: 52
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 52
	}

	public virtual string Prefix
	{
		 get { } //Length: 52
	}

	public virtual char QuoteChar
	{
		 get { } //Length: 52
	}

	public virtual ReadState ReadState
	{
		 get { } //Length: 52
	}

	public virtual IXmlSchemaInfo SchemaInfo
	{
		 get { } //Length: 52
	}

	public virtual XmlReaderSettings Settings
	{
		 get { } //Length: 142
	}

	public virtual string Value
	{
		 get { } //Length: 52
	}

	public virtual Type ValueType
	{
		 get { } //Length: 52
	}

	public virtual string XmlLang
	{
		 get { } //Length: 52
	}

	public virtual XmlSpace XmlSpace
	{
		 get { } //Length: 52
	}

	public XmlAsyncCheckReader(XmlReader reader) { }

	private void CheckAsync() { }

	public virtual void Close() { }

	public static XmlAsyncCheckReader CreateAsyncCheckWrapper(XmlReader reader) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual int get_AttributeCount() { }

	public virtual string get_BaseURI() { }

	public virtual bool get_CanReadBinaryContent() { }

	public virtual bool get_CanReadValueChunk() { }

	public virtual bool get_CanResolveEntity() { }

	internal XmlReader get_CoreReader() { }

	public virtual int get_Depth() { }

	internal virtual IDtdInfo get_DtdInfo() { }

	public virtual bool get_EOF() { }

	public virtual bool get_HasAttributes() { }

	public virtual bool get_HasValue() { }

	public virtual bool get_IsDefault() { }

	public virtual bool get_IsEmptyElement() { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	internal virtual XmlNamespaceManager get_NamespaceManager() { }

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

	public virtual string GetAttribute(string name, string namespaceURI) { }

	public virtual string GetAttribute(int i) { }

	public virtual bool IsStartElement(string localname, string ns) { }

	public virtual bool IsStartElement() { }

	public virtual string LookupNamespace(string prefix) { }

	public virtual bool MoveToAttribute(string name) { }

	public virtual void MoveToAttribute(int i) { }

	public virtual XmlNodeType MoveToContent() { }

	public virtual bool MoveToElement() { }

	public virtual bool MoveToFirstAttribute() { }

	public virtual bool MoveToNextAttribute() { }

	public virtual bool Read() { }

	public virtual bool ReadAttributeValue() { }

	public virtual int ReadContentAsBase64(Byte[] buffer, int index, int count) { }

	public virtual int ReadContentAsBinHex(Byte[] buffer, int index, int count) { }

	public virtual bool ReadContentAsBoolean() { }

	public virtual int ReadContentAsInt() { }

	public virtual string ReadContentAsString() { }

	public virtual bool ReadElementContentAsBoolean() { }

	public virtual int ReadElementContentAsInt() { }

	public virtual string ReadElementContentAsString() { }

	public virtual string ReadElementString() { }

	public virtual void ReadEndElement() { }

	public virtual string ReadInnerXml() { }

	public virtual void ReadStartElement(string name) { }

	public virtual void ReadStartElement() { }

	public virtual string ReadString() { }

	public virtual XmlReader ReadSubtree() { }

	public virtual bool ReadToDescendant(string name) { }

	public virtual bool ReadToFollowing(string name) { }

	public virtual bool ReadToNextSibling(string name) { }

	public virtual int ReadValueChunk(Char[] buffer, int index, int count) { }

	public virtual void ResolveEntity() { }

	public virtual void Skip() { }

}

