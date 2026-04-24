namespace ProtoBuf;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class ProtoPartialIgnoreAttribute : ProtoIgnoreAttribute
{
	private readonly string memberName; //Field offset: 0x10

	public string MemberName
	{
		 get { } //Length: 5
	}

	public ProtoPartialIgnoreAttribute(string memberName) { }

	public string get_MemberName() { }

}

