using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000391")]
public enum RailSystemState
{
	[Token(Token = "0x40014E4")]
	kSystemStateUnknown = 0,
	[Token(Token = "0x40014E5")]
	kSystemStatePlatformOnline = 1,
	[Token(Token = "0x40014E6")]
	kSystemStatePlatformOffline = 2,
	[Token(Token = "0x40014E7")]
	kSystemStatePlatformExit = 3,
	[Token(Token = "0x40014E8")]
	kSystemStatePlayerOwnershipExpired = 20,
	[Token(Token = "0x40014E9")]
	kSystemStatePlayerOwnershipActivated = 21,
	[Token(Token = "0x40014EA")]
	kSystemStatePlayerOwnershipBanned = 22,
	[Token(Token = "0x40014EB")]
	kSystemStateGameExitByAntiAddiction = 40
}
