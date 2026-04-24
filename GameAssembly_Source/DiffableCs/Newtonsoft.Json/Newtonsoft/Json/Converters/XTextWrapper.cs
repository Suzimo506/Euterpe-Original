namespace Newtonsoft.Json.Converters;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class XTextWrapper : XObjectWrapper
{

	public virtual IXmlNode ParentNode
	{
		 get { } //Length: 87
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private XText Text
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private get { } //Length: 119
	}

	public virtual string Value
	{
		 get { } //Length: 30
	}

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public XTextWrapper(XText text) { }

	public virtual IXmlNode get_ParentNode() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private XText get_Text() { }

	public virtual string get_Value() { }

}

