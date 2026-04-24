using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200036D")]
public enum EnumRailSmallObjectUpdateState
{
	[Token(Token = "0x40014A0")]
	kRailSmallObjectUnknwonState,
	[Token(Token = "0x40014A1")]
	kRailSmallObjectNotExist,
	[Token(Token = "0x40014A2")]
	kRailSmallObjectDownloading,
	[Token(Token = "0x40014A3")]
	kRailSmallObjectNeedUpdate,
	[Token(Token = "0x40014A4")]
	kRailSmallObjectUpToDate
}
