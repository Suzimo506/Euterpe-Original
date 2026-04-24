namespace rail;

public class RailInviteOptions
{
	public string additional_message; //Field offset: 0x10
	public uint expire_time; //Field offset: 0x18
	public EnumRailUsersInviteType invite_type; //Field offset: 0x1C
	public bool need_respond_in_game; //Field offset: 0x20

	public RailInviteOptions() { }

}

