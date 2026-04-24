using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003BE")]
public enum EnumRailUsersLimits
{
	[Token(Token = "0x4001586")]
	kRailUsersLimitsNone,
	[Token(Token = "0x4001587")]
	kRailUsersLimitsNoChats,
	[Token(Token = "0x4001588")]
	kRailUsersLimitsNoTrading,
	[Token(Token = "0x4001589")]
	kRailUsersLimitsNoRoomChat,
	[Token(Token = "0x400158A")]
	kRailUsersLimitsNoVoiceSpeaking,
	[Token(Token = "0x400158B")]
	kRailUsersLimitsNoGameInvited,
	[Token(Token = "0x400158C")]
	kRailUsersLimitsNoGameInvitee
}
