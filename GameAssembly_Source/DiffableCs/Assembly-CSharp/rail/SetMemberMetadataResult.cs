namespace rail;

public class SetMemberMetadataResult : EventBase
{
	public ulong room_id; //Field offset: 0x30
	public RailID member_id; //Field offset: 0x38

	public SetMemberMetadataResult() { }

}

