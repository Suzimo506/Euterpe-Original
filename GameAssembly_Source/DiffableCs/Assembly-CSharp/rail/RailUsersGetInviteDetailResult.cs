namespace rail;

public class RailUsersGetInviteDetailResult : EventBase
{
	public string command_line; //Field offset: 0x30
	public EnumRailUsersInviteType invite_type; //Field offset: 0x38
	public RailID inviter_id; //Field offset: 0x40

	public RailUsersGetInviteDetailResult() { }

}

