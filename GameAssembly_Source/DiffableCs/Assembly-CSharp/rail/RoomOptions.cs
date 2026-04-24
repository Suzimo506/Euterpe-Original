namespace rail;

public class RoomOptions
{
	public uint max_members; //Field offset: 0x10
	public string password; //Field offset: 0x18
	public EnumRoomType type; //Field offset: 0x20
	public bool enable_team_voice; //Field offset: 0x24
	public string room_tag; //Field offset: 0x28

	public RoomOptions() { }

}

