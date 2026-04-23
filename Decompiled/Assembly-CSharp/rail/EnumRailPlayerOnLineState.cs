using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000334")]
public enum EnumRailPlayerOnLineState
{
	[Token(Token = "0x40012AA")]
	kRailOnlineStateUnknown,
	[Token(Token = "0x40012AB")]
	kRailOnlineStateOffLine,
	[Token(Token = "0x40012AC")]
	kRailOnlineStateOnLine,
	[Token(Token = "0x40012AD")]
	kRailOnlineStateBusy,
	[Token(Token = "0x40012AE")]
	kRailOnlineStateLeave,
	[Token(Token = "0x40012AF")]
	kRailOnlineStateGameDefinePlayingState
}
