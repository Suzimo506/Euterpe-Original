using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000295")]
public enum EnumCommonLimit
{
	[Token(Token = "0x4001046")]
	kRailCommonMaxRepeatedKeys = 50,
	[Token(Token = "0x4001047")]
	kRailCommonUsersInviteMaxUsersOnce = 128,
	[Token(Token = "0x4001048")]
	kRailCommonMaxKeyLength = 256,
	[Token(Token = "0x4001049")]
	kRailCommonMaxValueLength = 1024,
	[Token(Token = "0x400104A")]
	kRailCommonUtilsCheckDirtyWordsStringMaxLength = 16384
}
