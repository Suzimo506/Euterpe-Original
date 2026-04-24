using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003A3")]
public enum EnumRailSpaceWorkOrderBy
{
	[Token(Token = "0x400150E")]
	kRailSpaceWorkOrderByLastUpdateTime = 0,
	[Token(Token = "0x400150F")]
	kRailSpaceWorkOrderByCreateTime = 1,
	[Token(Token = "0x4001510")]
	kRailSpaceWorkOrderByDownloadCount = 2,
	[Token(Token = "0x4001511")]
	kRailSpaceWorkOrderByScore = 3,
	[Token(Token = "0x4001512")]
	kRailSpaceWorkOrderBySubscribedCount = 4,
	[Token(Token = "0x4001513")]
	kRailSpaceWorkOrderByRate = 10,
	[Token(Token = "0x4001514")]
	kRailSpaceWorkOrderByBestMatch = 11
}
