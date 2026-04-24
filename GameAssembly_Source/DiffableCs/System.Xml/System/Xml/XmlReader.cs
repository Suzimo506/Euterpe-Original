namespace System.Xml;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class XmlReader : IDisposable
{
	[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private struct XmlReaderDebuggerDisplayProxy
	{
		private XmlReader reader; //Field offset: 0x0

		internal XmlReaderDebuggerDisplayProxy(XmlReader reader) { }

		public virtual string ToString() { }

	}

	private static uint IsTextualNodeBitmap; //Field offset: 0x0
	private static uint CanReadContentAsBitmap; //Field offset: 0x4
	private static uint HasValueBitmap; //Field offset: 0x8

	public abstract int AttributeCount
	{
		 get { } //Length: 0
	}

	public abstract string BaseURI
	{
		 get { } //Length: 0
	}

	public override bool CanReadBinaryContent
	{
		 get { } //Length: 3
	}

	public override bool CanReadValueChunk
	{
		 get { } //Length: 3
	}

	public override bool CanResolveEntity
	{
		 get { } //Length: 3
	}

	private object debuggerDisplayProxy
	{
		private get { } //Length: 87
	}

	public abstract int Depth
	{
		 get { } //Length: 0
	}

	internal override IDtdInfo DtdInfo
	{
		internal get { } //Length: 3
	}

	public abstract bool EOF
	{
		 get { } //Length: 0
	}

	public override bool HasAttributes
	{
		 get { } //Length: 30
	}

	public override bool HasValue
	{
		 get { } //Length: 101
	}

	public override bool IsDefault
	{
		 get { } //Length: 3
	}

	internal bool IsDefaultInternal
	{
		internal get { } //Length: 220
	}

	public abstract bool IsEmptyElement
	{
		 get { } //Length: 0
	}

	public abstract string LocalName
	{
		 get { } //Length: 0
	}

	public override string Name
	{
		 get { } //Length: 243
	}

	internal override XmlNamespaceManager NamespaceManager
	{
		internal get { } //Length: 3
	}

	public abstract string NamespaceURI
	{
		 get { } //Length: 0
	}

	public abstract XmlNameTable NameTable
	{
		 get { } //Length: 0
	}

	public abstract XmlNodeType NodeType
	{
		 get { } //Length: 0
	}

	public abstract string Prefix
	{
		 get { } //Length: 0
	}

	public override char QuoteChar
	{
		 get { } //Length: 6
	}

	public abstract ReadState ReadState
	{
		 get { } //Length: 0
	}

	public override IXmlSchemaInfo SchemaInfo
	{
		 get { } //Length: 56
	}

	public override XmlReaderSettings Settings
	{
		 get { } //Length: 3
	}

	public abstract string Value
	{
		 get { } //Length: 0
	}

	public override Type ValueType
	{
		 get { } //Length: 85
	}

	public override string XmlLang
	{
		 get { } //Length: 53
	}

	public override XmlSpace XmlSpace
	{
		 get { } //Length: 3
	}

	private static XmlReader() { }

	protected XmlReader() { }

	private static string AddLineInfo(string message, IXmlLineInfo lineInfo) { }

	internal static int CalcBufferSize(Stream input) { }

	internal static bool CanReadContentAs(XmlNodeType nodeType) { }

	internal bool CanReadContentAs() { }

	public override void Close() { }

	public static XmlReader Create(TextReader input, XmlReaderSettings settings, string baseUri) { }

	public static XmlReader Create(TextReader input) { }

	public static XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri) { }

	public static XmlReader Create(Stream input) { }

	internal Exception CreateReadContentAsException(string methodName) { }

	internal static Exception CreateReadContentAsException(string methodName, XmlNodeType nodeType, IXmlLineInfo lineInfo) { }

	internal Exception CreateReadElementContentAsException(string methodName) { }

	internal static Exception CreateReadElementContentAsException(string methodName, XmlNodeType nodeType, IXmlLineInfo lineInfo) { }

	internal static XmlReader CreateSqlReader(Stream input, XmlReaderSettings settings, XmlParserContext inputContext) { }

	private XmlWriter CreateWriterForInnerOuterXml(StringWriter sw) { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	private void FinishReadElementContentAsXxx() { }

	public abstract int get_AttributeCount() { }

	public abstract string get_BaseURI() { }

	public override bool get_CanReadBinaryContent() { }

	public override bool get_CanReadValueChunk() { }

	public override bool get_CanResolveEntity() { }

	private object get_debuggerDisplayProxy() { }

	public abstract int get_Depth() { }

	internal override IDtdInfo get_DtdInfo() { }

	public abstract bool get_EOF() { }

	public override bool get_HasAttributes() { }

	public override bool get_HasValue() { }

	public override bool get_IsDefault() { }

	internal bool get_IsDefaultInternal() { }

	public abstract bool get_IsEmptyElement() { }

	public abstract string get_LocalName() { }

	public override string get_Name() { }

	internal override XmlNamespaceManager get_NamespaceManager() { }

	public abstract string get_NamespaceURI() { }

	public abstract XmlNameTable get_NameTable() { }

	public abstract XmlNodeType get_NodeType() { }

	public abstract string get_Prefix() { }

	public override char get_QuoteChar() { }

	public abstract ReadState get_ReadState() { }

	public override IXmlSchemaInfo get_SchemaInfo() { }

	public override XmlReaderSettings get_Settings() { }

	public abstract string get_Value() { }

	public override Type get_ValueType() { }

	public override string get_XmlLang() { }

	public override XmlSpace get_XmlSpace() { }

	public abstract string GetAttribute(string name) { }

	public abstract string GetAttribute(string name, string namespaceURI) { }

	public abstract string GetAttribute(int i) { }

	internal static bool HasValueInternal(XmlNodeType nodeType) { }

	internal string InternalReadContentAsString() { }

	public override bool IsStartElement() { }

	public override bool IsStartElement(string localname, string ns) { }

	internal static bool IsTextualNode(XmlNodeType nodeType) { }

	public abstract string LookupNamespace(string prefix) { }

	public abstract bool MoveToAttribute(string name) { }

	public override void MoveToAttribute(int i) { }

	public override XmlNodeType MoveToContent() { }

	public abstract bool MoveToElement() { }

	public abstract bool MoveToFirstAttribute() { }

	public abstract bool MoveToNextAttribute() { }

	public abstract bool Read() { }

	public abstract bool ReadAttributeValue() { }

	public override int ReadContentAsBase64(Byte[] buffer, int index, int count) { }

	public override int ReadContentAsBinHex(Byte[] buffer, int index, int count) { }

	public override bool ReadContentAsBoolean() { }

	public override int ReadContentAsInt() { }

	public override string ReadContentAsString() { }

	public override bool ReadElementContentAsBoolean() { }

	public override int ReadElementContentAsInt() { }

	public override string ReadElementContentAsString() { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override string ReadElementString() { }

	public override void ReadEndElement() { }

	public override string ReadInnerXml() { }

	public override void ReadStartElement(string name) { }

	public override void ReadStartElement() { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override string ReadString() { }

	public override XmlReader ReadSubtree() { }

	public override bool ReadToDescendant(string name) { }

	public override bool ReadToFollowing(string name) { }

	public override bool ReadToNextSibling(string name) { }

	public override int ReadValueChunk(Char[] buffer, int index, int count) { }

	public abstract void ResolveEntity() { }

	private void SetNamespacesFlag(XmlTextWriter xtw) { }

	private bool SetupReadElementContentAsXxx(string methodName) { }

	public override void Skip() { }

	private bool SkipSubtree() { }

	private void WriteAttributeValue(XmlWriter xtw) { }

	private void WriteNode(XmlWriter xtw, bool defattr) { }

}

