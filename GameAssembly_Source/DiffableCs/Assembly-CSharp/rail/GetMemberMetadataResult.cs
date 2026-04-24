namespace rail;

public class GetMemberMetadataResult : EventBase
{
	public List<RailKeyValue> key_value; //Field offset: 0x30
	public ulong room_id; //Field offset: 0x38
	public RailID member_id; //Field offset: 0x40

	public GetMemberMetadataResult() { }

}

