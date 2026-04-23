using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003BC")]
public enum EnumRailUsersInviteResponseType
{
	[Token(Token = "0x400157D")]
	kRailInviteResponseTypeUnknown,
	[Token(Token = "0x400157E")]
	kRailInviteResponseTypeAccepted,
	[Token(Token = "0x400157F")]
	kRailInviteResponseTypeRejected,
	[Token(Token = "0x4001580")]
	kRailInviteResponseTypeIgnore,
	[Token(Token = "0x4001581")]
	kRailInviteResponseTypeTimeout
}
