namespace Sirenix.Serialization;

public interface ISerializationPolicy
{

	public bool AllowNonSerializableTypes
	{
		 get { } //Length: 0
	}

	public string ID
	{
		 get { } //Length: 0
	}

	public bool get_AllowNonSerializableTypes() { }

	public string get_ID() { }

	public bool ShouldSerializeMember(MemberInfo member) { }

}

