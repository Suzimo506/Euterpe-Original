namespace Newtonsoft.Json.Converters;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class XmlNodeWrapper : IXmlNode
{
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly XmlNode _node; //Field offset: 0x10
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private List<IXmlNode> _childNodes; //Field offset: 0x18
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private List<IXmlNode> _attributes; //Field offset: 0x20

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override List<IXmlNode> Attributes
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 1335
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override List<IXmlNode> ChildNodes
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 1191
	}

	private bool HasAttributes
	{
		private get { } //Length: 200
	}

	public override string LocalName
	{
		 get { } //Length: 39
	}

	public override string NamespaceUri
	{
		 get { } //Length: 39
	}

	public override XmlNodeType NodeType
	{
		 get { } //Length: 39
	}

	public override IXmlNode ParentNode
	{
		 get { } //Length: 176
	}

	public override string Value
	{
		 get { } //Length: 39
		 set { } //Length: 39
	}

	public override object WrappedNode
	{
		 get { } //Length: 5
	}

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public XmlNodeWrapper(XmlNode node) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override IXmlNode AppendChild(IXmlNode newChild) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override List<IXmlNode> get_Attributes() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override List<IXmlNode> get_ChildNodes() { }

	private bool get_HasAttributes() { }

	public override string get_LocalName() { }

	public override string get_NamespaceUri() { }

	public override XmlNodeType get_NodeType() { }

	public override IXmlNode get_ParentNode() { }

	public override string get_Value() { }

	public override object get_WrappedNode() { }

	public override void set_Value(string value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal static IXmlNode WrapNode(XmlNode node) { }

}

