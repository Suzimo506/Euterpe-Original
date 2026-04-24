using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003C9")]
public class RailUsersRespondInvitation : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400159F")]
	public RailInviteOptions original_invite_option;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40015A0")]
	public EnumRailUsersInviteResponseType response;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40015A1")]
	public RailID inviter_id;

	[Address(RVA = "0x2721A70", Offset = "0x2720270", Length = "0xC5")]
	[Token(Token = "0x6002F76")]
	public RailUsersRespondInvitation()
	{
	}
}
