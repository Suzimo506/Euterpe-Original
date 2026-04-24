namespace rail;

public class RailUsersRespondInvitation : EventBase
{
	public RailInviteOptions original_invite_option; //Field offset: 0x30
	public EnumRailUsersInviteResponseType response; //Field offset: 0x38
	public RailID inviter_id; //Field offset: 0x40

	public RailUsersRespondInvitation() { }

}

