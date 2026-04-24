using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003C6")]
public class RailUsersInviteJoinGameResult : EventBase
{
	[Token(Token = "0x400159A")]
	[FieldOffset(Offset = "0x30")]
	public EnumRailUsersInviteResponseType response_value;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400159B")]
	public RailID invitee_id;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400159C")]
	public EnumRailUsersInviteType invite_type;

	[Token(Token = "0x6002F73")]
	[Address(RVA = "0x2721930", Offset = "0x2720130", Length = "0x9D")]
	public RailUsersInviteJoinGameResult()
	{
	}
}
