namespace Newtonsoft.Json.Converters;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class XCommentWrapper : XObjectWrapper
{

	public virtual IXmlNode ParentNode
	{
		 get { } //Length: 87
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private XComment Text
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private get { } //Length: 119
	}

	public virtual string Value
	{
		 get { } //Length: 30
	}

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public XCommentWrapper(XComment text) { }

	public virtual IXmlNode get_ParentNode() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private XComment get_Text() { }

	public virtual string get_Value() { }

}

