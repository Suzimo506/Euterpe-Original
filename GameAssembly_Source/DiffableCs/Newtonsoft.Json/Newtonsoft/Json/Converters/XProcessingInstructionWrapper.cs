namespace Newtonsoft.Json.Converters;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class XProcessingInstructionWrapper : XObjectWrapper
{

	public virtual string LocalName
	{
		 get { } //Length: 30
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private XProcessingInstruction ProcessingInstruction
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private get { } //Length: 119
	}

	public virtual string Value
	{
		 get { } //Length: 30
	}

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public XProcessingInstructionWrapper(XProcessingInstruction processingInstruction) { }

	public virtual string get_LocalName() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private XProcessingInstruction get_ProcessingInstruction() { }

	public virtual string get_Value() { }

}

