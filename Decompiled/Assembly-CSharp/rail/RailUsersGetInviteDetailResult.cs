using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003C3")]
public class RailUsersGetInviteDetailResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001594")]
	public string command_line;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001595")]
	public EnumRailUsersInviteType invite_type;

	[Token(Token = "0x4001596")]
	[FieldOffset(Offset = "0x40")]
	public RailID inviter_id;

	[Address(RVA = "0x2721750", Offset = "0x271FF50", Length = "0x9D")]
	[Token(Token = "0x6002F70")]
	public RailUsersGetInviteDetailResult()
	{
	}
}
