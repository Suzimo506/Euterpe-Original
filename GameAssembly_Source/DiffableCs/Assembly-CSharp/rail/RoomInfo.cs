namespace rail;

public class RoomInfo
{
	public bool has_password; //Field offset: 0x10
	public uint max_members; //Field offset: 0x14
	public string room_name; //Field offset: 0x18
	public RailID game_server_rail_id; //Field offset: 0x20
	public uint create_time; //Field offset: 0x28
	public uint current_members; //Field offset: 0x2C
	public EnumRoomType type; //Field offset: 0x30
	public bool is_joinable; //Field offset: 0x34
	public ulong room_id; //Field offset: 0x38
	public List<RailKeyValue> room_kvs; //Field offset: 0x40
	public string room_tag; //Field offset: 0x48
	public RailID owner_id; //Field offset: 0x50

	public RoomInfo() { }

}

