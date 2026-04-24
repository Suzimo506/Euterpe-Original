namespace Newtonsoft.Json.Converters;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class XElementWrapper : XContainerWrapper, IXmlElement, IXmlNode
{
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private List<IXmlNode> _attributes; //Field offset: 0x20

	public virtual List<IXmlNode> Attributes
	{
		 get { } //Length: 827
	}

	private XElement Element
	{
		private get { } //Length: 119
	}

	public override bool IsEmpty
	{
		 get { } //Length: 35
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual string LocalName
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 39
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual string NamespaceUri
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 41
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual string Value
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 35
	}

	public XElementWrapper(XElement element) { }

	public virtual IXmlNode AppendChild(IXmlNode newChild) { }

	public virtual List<IXmlNode> get_Attributes() { }

	private XElement get_Element() { }

	public override bool get_IsEmpty() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual string get_LocalName() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual string get_NamespaceUri() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual string get_Value() { }

	public override string GetPrefixOfNamespace(string namespaceUri) { }

	private bool HasImplicitNamespaceAttribute(string namespaceUri) { }

	public override void SetAttributeNode(IXmlNode attribute) { }

}

