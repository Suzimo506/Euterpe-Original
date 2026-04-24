using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003C2")]
public class RailUsersCancelInviteResult : EventBase
{
	[Token(Token = "0x4001593")]
	[FieldOffset(Offset = "0x30")]
	public EnumRailUsersInviteType invite_type;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002F6F")]
	public RailUsersCancelInviteResult()
	{
	}
}
