using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003C7")]
public class RailUsersInviteUsersResult : EventBase
{
	[Token(Token = "0x400159D")]
	[FieldOffset(Offset = "0x30")]
	public EnumRailUsersInviteType invite_type;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002F74")]
	public RailUsersInviteUsersResult()
	{
	}
}
