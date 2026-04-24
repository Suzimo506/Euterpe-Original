namespace System.Xml;

public class XmlNodeReader : XmlReader, IXmlNamespaceResolver
{
	private XmlNodeReaderNavigator readerNav; //Field offset: 0x10
	private XmlNodeType nodeType; //Field offset: 0x18
	private int curDepth; //Field offset: 0x1C
	private ReadState readState; //Field offset: 0x20
	private bool fEOF; //Field offset: 0x24
	private bool bResolveEntity; //Field offset: 0x25
	private bool bStartFromDocument; //Field offset: 0x26
	private bool bInReadBinary; //Field offset: 0x27
	private ReadContentAsBinaryHelper readBinaryHelper; //Field offset: 0x28

	public virtual int AttributeCount
	{
		 get { } //Length: 48
	}

	public virtual string BaseURI
	{
		 get { } //Length: 48
	}

	public virtual bool CanReadBinaryContent
	{
		 get { } //Length: 3
	}

	public virtual bool CanResolveEntity
	{
		 get { } //Length: 3
	}

	public virtual int Depth
	{
		 get { } //Length: 4
	}

	internal virtual IDtdInfo DtdInfo
	{
		internal get { } //Length: 36
	}

	public virtual bool EOF
	{
		 get { } //Length: 14
	}

	public virtual bool HasAttributes
	{
		 get { } //Length: 30
	}

	public virtual bool HasValue
	{
		 get { } //Length: 126
	}

	public virtual bool IsDefault
	{
		 get { } //Length: 283
	}

	public virtual bool IsEmptyElement
	{
		 get { } //Length: 42
	}

	public virtual string LocalName
	{
		 get { } //Length: 256
	}

	public virtual string Name
	{
		 get { } //Length: 91
	}

	public virtual string NamespaceURI
	{
		 get { } //Length: 110
	}

	public virtual XmlNameTable NameTable
	{
		 get { } //Length: 27
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 13
	}

	public virtual string Prefix
	{
		 get { } //Length: 110
	}

	public virtual ReadState ReadState
	{
		 get { } //Length: 4
	}

	public virtual IXmlSchemaInfo SchemaInfo
	{
		 get { } //Length: 61
	}

	public virtual string Value
	{
		 get { } //Length: 91
	}

	public virtual string XmlLang
	{
		 get { } //Length: 110
	}

	public virtual XmlSpace XmlSpace
	{
		 get { } //Length: 61
	}

	public XmlNodeReader(XmlNode node) { }

	public virtual void Close() { }

	private void FinishReadBinary() { }

	public virtual int get_AttributeCount() { }

	public virtual string get_BaseURI() { }

	public virtual bool get_CanReadBinaryContent() { }

	public virtual bool get_CanResolveEntity() { }

	public virtual int get_Depth() { }

	internal virtual IDtdInfo get_DtdInfo() { }

	public virtual bool get_EOF() { }

	public virtual bool get_HasAttributes() { }

	public virtual bool get_HasValue() { }

	public virtual bool get_IsDefault() { }

	public virtual bool get_IsEmptyElement() { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	public virtual string get_NamespaceURI() { }

	public virtual XmlNameTable get_NameTable() { }

	public virtual XmlNodeType get_NodeType() { }

	public virtual string get_Prefix() { }

	public virtual ReadState get_ReadState() { }

	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	public virtual string get_Value() { }

	public virtual string get_XmlLang() { }

	public virtual XmlSpace get_XmlSpace() { }

	public virtual string GetAttribute(int attributeIndex) { }

	public virtual string GetAttribute(string name, string namespaceURI) { }

	public virtual string GetAttribute(string name) { }

	internal bool IsInReadingStates() { }

	public virtual string LookupNamespace(string prefix) { }

	public virtual void MoveToAttribute(int attributeIndex) { }

	public virtual bool MoveToAttribute(string name) { }

	public virtual bool MoveToElement() { }

	public virtual bool MoveToFirstAttribute() { }

	public virtual bool MoveToNextAttribute() { }

	private bool Read(bool fSkipChildren) { }

	public virtual bool Read() { }

	public virtual bool ReadAttributeValue() { }

	private bool ReadAtZeroLevel(bool fSkipChildren) { }

	public virtual int ReadContentAsBase64(Byte[] buffer, int index, int count) { }

	public virtual int ReadContentAsBinHex(Byte[] buffer, int index, int count) { }

	private bool ReadForward(bool fSkipChildren) { }

	private bool ReadNextNode(bool fSkipChildren) { }

	public virtual string ReadString() { }

	private void ReSetReadingMarks() { }

	public virtual void ResolveEntity() { }

	private void SetEndOfFile() { }

	public virtual void Skip() { }

	private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

