namespace rail;

public class RoomMemberInfo
{
	public string member_name; //Field offset: 0x10
	public uint member_index; //Field offset: 0x18
	public ulong room_id; //Field offset: 0x20
	public List<RailKeyValue> member_kvs; //Field offset: 0x28
	public RailID member_id; //Field offset: 0x30

	public RoomMemberInfo() { }

}

