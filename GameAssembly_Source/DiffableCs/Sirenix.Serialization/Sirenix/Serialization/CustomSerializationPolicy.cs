namespace Sirenix.Serialization;

public class CustomSerializationPolicy : ISerializationPolicy
{
	private string id; //Field offset: 0x10
	private bool allowNonSerializableTypes; //Field offset: 0x18
	private Func<MemberInfo, Boolean> shouldSerializeFunc; //Field offset: 0x20

	public override bool AllowNonSerializableTypes
	{
		 get { } //Length: 5
	}

	public override string ID
	{
		 get { } //Length: 5
	}

	public CustomSerializationPolicy(string id, bool allowNonSerializableTypes, Func<MemberInfo, Boolean> shouldSerializeFunc) { }

	public override bool get_AllowNonSerializableTypes() { }

	public override string get_ID() { }

	public override bool ShouldSerializeMember(MemberInfo member) { }

}

