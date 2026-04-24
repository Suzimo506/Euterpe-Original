namespace rail;

public class GetRoomMetadataResult : EventBase
{
	public List<RailKeyValue> key_value; //Field offset: 0x30
	public ulong room_id; //Field offset: 0x38

	public GetRoomMetadataResult() { }

}

