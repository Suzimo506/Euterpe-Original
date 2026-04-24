namespace Newtonsoft.Json.Converters;

[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal interface IXmlNode
{

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public List<IXmlNode> Attributes
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 0
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public List<IXmlNode> ChildNodes
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 0
	}

	public string LocalName
	{
		 get { } //Length: 0
	}

	public string NamespaceUri
	{
		 get { } //Length: 0
	}

	public XmlNodeType NodeType
	{
		 get { } //Length: 0
	}

	public IXmlNode ParentNode
	{
		 get { } //Length: 0
	}

	public string Value
	{
		 get { } //Length: 0
	}

	public object WrappedNode
	{
		 get { } //Length: 0
	}

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public IXmlNode AppendChild(IXmlNode newChild) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public List<IXmlNode> get_Attributes() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public List<IXmlNode> get_ChildNodes() { }

	public string get_LocalName() { }

	public string get_NamespaceUri() { }

	public XmlNodeType get_NodeType() { }

	public IXmlNode get_ParentNode() { }

	public string get_Value() { }

	public object get_WrappedNode() { }

}

