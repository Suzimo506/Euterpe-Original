namespace System.Xml.XPath;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class XPathNavigator : XPathItem, ICloneable, IXPathNavigable, IXmlNamespaceResolver
{
	[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public struct DebuggerDisplayProxy
	{
		private XPathNavigator nav; //Field offset: 0x0

		public DebuggerDisplayProxy(XPathNavigator nav) { }

		public virtual string ToString() { }

	}

	internal static readonly XPathNavigatorKeyComparer comparer; //Field offset: 0x0
	internal static readonly Char[] NodeTypeLetter; //Field offset: 0x8
	internal static readonly Char[] UniqueIdTbl; //Field offset: 0x10
	internal static readonly Int32[] ContentKindMasks; //Field offset: 0x18

	public abstract string BaseURI
	{
		 get { } //Length: 0
	}

	private object debuggerDisplayProxy
	{
		private get { } //Length: 87
	}

	public abstract string LocalName
	{
		 get { } //Length: 0
	}

	public abstract string Name
	{
		 get { } //Length: 0
	}

	public abstract string NamespaceURI
	{
		 get { } //Length: 0
	}

	public abstract XmlNameTable NameTable
	{
		 get { } //Length: 0
	}

	public abstract XPathNodeType NodeType
	{
		 get { } //Length: 0
	}

	public abstract string Prefix
	{
		 get { } //Length: 0
	}

	public override IXmlSchemaInfo SchemaInfo
	{
		 get { } //Length: 56
	}

	public virtual object TypedValue
	{
		 get { } //Length: 509
	}

	public override object UnderlyingObject
	{
		 get { } //Length: 3
	}

	public virtual bool ValueAsBoolean
	{
		 get { } //Length: 469
	}

	public virtual DateTime ValueAsDateTime
	{
		 get { } //Length: 469
	}

	public virtual double ValueAsDouble
	{
		 get { } //Length: 469
	}

	public virtual int ValueAsInt
	{
		 get { } //Length: 469
	}

	public virtual long ValueAsLong
	{
		 get { } //Length: 469
	}

	public virtual Type ValueType
	{
		 get { } //Length: 216
	}

	public override string XmlLang
	{
		 get { } //Length: 177
	}

	public virtual XmlSchemaType XmlType
	{
		 get { } //Length: 139
	}

	private static XPathNavigator() { }

	protected XPathNavigator() { }

	public abstract XPathNavigator Clone() { }

	public override XmlNodeOrder ComparePosition(XPathNavigator nav) { }

	private XmlNodeOrder CompareSiblings(XPathNavigator n1, XPathNavigator n2) { }

	public override XPathNavigator CreateNavigator() { }

	public override object Evaluate(XPathExpression expr, XPathNodeIterator context) { }

	public override object Evaluate(XPathExpression expr) { }

	public abstract string get_BaseURI() { }

	private object get_debuggerDisplayProxy() { }

	public abstract string get_LocalName() { }

	public abstract string get_Name() { }

	public abstract string get_NamespaceURI() { }

	public abstract XmlNameTable get_NameTable() { }

	public abstract XPathNodeType get_NodeType() { }

	public abstract string get_Prefix() { }

	public override IXmlSchemaInfo get_SchemaInfo() { }

	public virtual object get_TypedValue() { }

	public override object get_UnderlyingObject() { }

	public virtual bool get_ValueAsBoolean() { }

	public virtual DateTime get_ValueAsDateTime() { }

	public virtual double get_ValueAsDouble() { }

	public virtual int get_ValueAsInt() { }

	public virtual long get_ValueAsLong() { }

	public virtual Type get_ValueType() { }

	public override string get_XmlLang() { }

	public virtual XmlSchemaType get_XmlType() { }

	internal static int GetContentKindMask(XPathNodeType type) { }

	private static int GetDepth(XPathNavigator nav) { }

	internal static int GetKindMask(XPathNodeType type) { }

	public override IDictionary<String, String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	public override bool IsDescendant(XPathNavigator nav) { }

	public abstract bool IsSamePosition(XPathNavigator other) { }

	internal static bool IsText(XPathNodeType type) { }

	public override string LookupNamespace(string prefix) { }

	public override string LookupPrefix(string namespaceURI) { }

	public abstract bool MoveTo(XPathNavigator other) { }

	public override bool MoveToAttribute(string localName, string namespaceURI) { }

	public override bool MoveToChild(string localName, string namespaceURI) { }

	public override bool MoveToChild(XPathNodeType type) { }

	public abstract bool MoveToFirstAttribute() { }

	public abstract bool MoveToFirstChild() { }

	public bool MoveToFirstNamespace() { }

	public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	public override bool MoveToFollowing(string localName, string namespaceURI, XPathNavigator end) { }

	public override bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	public abstract bool MoveToId(string id) { }

	public override bool MoveToNamespace(string name) { }

	public override bool MoveToNext(string localName, string namespaceURI) { }

	public override bool MoveToNext(XPathNodeType type) { }

	public abstract bool MoveToNext() { }

	public abstract bool MoveToNextAttribute() { }

	public bool MoveToNextNamespace() { }

	public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope) { }

	internal bool MoveToNonDescendant() { }

	public abstract bool MoveToParent() { }

	public override void MoveToRoot() { }

	public override XPathNodeIterator Select(string xpath) { }

	public override XPathNodeIterator Select(XPathExpression expr) { }

	public override XPathNodeIterator SelectChildren(XPathNodeType type) { }

	public override XPathNodeIterator SelectChildren(string name, string namespaceURI) { }

	public override XPathNodeIterator SelectDescendants(XPathNodeType type, bool matchSelf) { }

	public override XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf) { }

	private override object System.ICloneable.Clone() { }

	public virtual string ToString() { }

	public virtual object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

}

