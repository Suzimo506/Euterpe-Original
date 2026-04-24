namespace Newtonsoft.Json.Converters;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class XContainerWrapper : XObjectWrapper
{
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private List<IXmlNode> _childNodes; //Field offset: 0x18

	public virtual List<IXmlNode> ChildNodes
	{
		 get { } //Length: 577
	}

	private XContainer Container
	{
		private get { } //Length: 119
	}

	protected override bool HasChildNodes
	{
		 get { } //Length: 42
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual IXmlNode ParentNode
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 87
	}

	public XContainerWrapper(XContainer container) { }

	public virtual IXmlNode AppendChild(IXmlNode newChild) { }

	public virtual List<IXmlNode> get_ChildNodes() { }

	private XContainer get_Container() { }

	protected override bool get_HasChildNodes() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual IXmlNode get_ParentNode() { }

	internal static IXmlNode WrapNode(XObject node) { }

}

