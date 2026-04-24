namespace ProtoBuf;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class ProtoPartialMemberAttribute : ProtoMemberAttribute
{
	private readonly string memberName; //Field offset: 0x38

	public string MemberName
	{
		 get { } //Length: 5
	}

	public ProtoPartialMemberAttribute(int tag, string memberName) { }

	public string get_MemberName() { }

}

