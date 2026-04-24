namespace rail;

public class RailUsersInviteJoinGameResult : EventBase
{
	public EnumRailUsersInviteResponseType response_value; //Field offset: 0x30
	public RailID invitee_id; //Field offset: 0x38
	public EnumRailUsersInviteType invite_type; //Field offset: 0x40

	public RailUsersInviteJoinGameResult() { }

}

