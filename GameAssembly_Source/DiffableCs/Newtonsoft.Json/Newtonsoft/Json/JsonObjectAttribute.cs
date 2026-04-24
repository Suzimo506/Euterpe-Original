namespace Newtonsoft.Json;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class JsonObjectAttribute : JsonContainerAttribute
{
	private MemberSerialization _memberSerialization; //Field offset: 0x50
	internal Nullable<MissingMemberHandling> _missingMemberHandling; //Field offset: 0x54
	internal Nullable<Required> _itemRequired; //Field offset: 0x5C
	internal Nullable<NullValueHandling> _itemNullValueHandling; //Field offset: 0x64

	public MemberSerialization MemberSerialization
	{
		 get { } //Length: 4
	}

	public MemberSerialization get_MemberSerialization() { }

}

