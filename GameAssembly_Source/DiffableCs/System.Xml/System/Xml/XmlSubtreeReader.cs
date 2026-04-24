namespace System.Xml;

internal sealed class XmlSubtreeReader : XmlWrappingReader, IXmlLineInfo, IXmlNamespaceResolver
{
	private class NodeData
	{
		internal XmlNodeType type; //Field offset: 0x10
		internal string localName; //Field offset: 0x18
		internal string prefix; //Field offset: 0x20
		internal string name; //Field offset: 0x28
		internal string namespaceUri; //Field offset: 0x30
		internal string value; //Field offset: 0x38

		internal NodeData() { }

		internal void Set(XmlNodeType nodeType, string localName, string prefix, string name, string namespaceUri, string value) { }

	}

	private enum State
	{
		Initial = 0,
		Interactive = 1,
		Error = 2,
		EndOfFile = 3,
		Closed = 4,
		PopNamespaceScope = 5,
		ClearNsAttributes = 6,
		ReadElementContentAsBase64 = 7,
		ReadElementContentAsBinHex = 8,
		ReadContentAsBase64 = 9,
		ReadContentAsBinHex = 10,
	}

	private int initialDepth; //Field offset: 0x20
	private State state; //Field offset: 0x24
	private XmlNamespaceManager nsManager; //Field offset: 0x28
	private NodeData[] nsAttributes; //Field offset: 0x30
	private int nsAttrCount; //Field offset: 0x38
	private int curNsAttr; //Field offset: 0x3C
	private string xmlns; //Field offset: 0x40
	private string xmlnsUri; //Field offset: 0x48
	private int nsIncReadOffset; //Field offset: 0x50
	private IncrementalReadDecoder binDecoder; //Field offset: 0x58
	private bool useCurNode; //Field offset: 0x60
	private NodeData curNode; //Field offset: 0x68
	private NodeData tmpNode; //Field offset: 0x70
	internal int InitialNamespaceAttributeCount; //Field offset: 0x78

	public virtual int AttributeCount
	{
		 get { } //Length: 74
	}

	public virtual string BaseURI
	{
		 get { } //Length: 39
	}

	public virtual bool CanReadBinaryContent
	{
		 get { } //Length: 39
	}

	public virtual bool CanReadValueChunk
	{
		 get { } //Length: 39
	}

	public virtual int Depth
	{
		 get { } //Length: 80
	}

	public virtual bool EOF
	{
		 get { } //Length: 18
	}

	private bool InAttributeActiveState
	{
		private get { } //Length: 20
	}

	private bool InNamespaceActiveState
	{
		private get { } //Length: 23
	}

	public virtual bool IsEmptyElement
	{
		 get { } //Length: 39
	}

	public virtual string LocalName
	{
		 get { } //Length: 63
	}

	public virtual string Name
	{
		 get { } //Length: 63
	}

	public virtual string NamespaceURI
	{
		 get { } //Length: 63
	}

	public virtual XmlNameTable NameTable
	{
		 get { } //Length: 39
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 62
	}

	public virtual string Prefix
	{
		 get { } //Length: 63
	}

	public virtual ReadState ReadState
	{
		 get { } //Length: 75
	}

	private override int System.Xml.IXmlLineInfo.LineNumber
	{
		private get { } //Length: 96
	}

	private override int System.Xml.IXmlLineInfo.LinePosition
	{
		private get { } //Length: 96
	}

	public virtual string Value
	{
		 get { } //Length: 63
	}

	internal XmlSubtreeReader(XmlReader reader) { }

	private void AddNamespace(string prefix, string ns) { }

	private void CheckBuffer(Array buffer, int index, int count) { }

	public virtual void Close() { }

	protected virtual void Dispose(bool disposing) { }

	private bool FinishReadContentAsBinary() { }

	private void FinishReadContentAsType() { }

	private bool FinishReadElementContentAsBinary() { }

	public virtual int get_AttributeCount() { }

	public virtual string get_BaseURI() { }

	public virtual bool get_CanReadBinaryContent() { }

	public virtual bool get_CanReadValueChunk() { }

	public virtual int get_Depth() { }

	public virtual bool get_EOF() { }

	private bool get_InAttributeActiveState() { }

	private bool get_InNamespaceActiveState() { }

	public virtual bool get_IsEmptyElement() { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	public virtual string get_NamespaceURI() { }

	public virtual XmlNameTable get_NameTable() { }

	public virtual XmlNodeType get_NodeType() { }

	public virtual string get_Prefix() { }

	public virtual ReadState get_ReadState() { }

	public virtual string get_Value() { }

	public virtual string GetAttribute(string name, string namespaceURI) { }

	public virtual string GetAttribute(int i) { }

	public virtual string GetAttribute(string name) { }

	private void InitReadContentAsType(string methodName) { }

	public virtual string LookupNamespace(string prefix) { }

	public virtual void MoveToAttribute(int i) { }

	public virtual bool MoveToAttribute(string name) { }

	public virtual bool MoveToElement() { }

	public virtual bool MoveToFirstAttribute() { }

	public virtual bool MoveToNextAttribute() { }

	private void MoveToNsAttribute(int index) { }

	private void ProcessNamespaces() { }

	public virtual bool Read() { }

	public virtual bool ReadAttributeValue() { }

	public virtual int ReadContentAsBase64(Byte[] buffer, int index, int count) { }

	public virtual int ReadContentAsBinHex(Byte[] buffer, int index, int count) { }

	public virtual bool ReadContentAsBoolean() { }

	public virtual int ReadContentAsInt() { }

	public virtual string ReadContentAsString() { }

	public virtual int ReadValueChunk(Char[] buffer, int index, int count) { }

	private void RemoveNamespace(string prefix, string localName) { }

	private void SetCurrentNode(NodeData node) { }

	private void SetEmptyNode() { }

	public virtual void Skip() { }

	private override int System.Xml.IXmlLineInfo.get_LineNumber() { }

	private override int System.Xml.IXmlLineInfo.get_LinePosition() { }

	private override bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

