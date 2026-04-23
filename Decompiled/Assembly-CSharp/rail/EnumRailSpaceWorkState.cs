using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003A7")]
public enum EnumRailSpaceWorkState
{
	[Token(Token = "0x4001522")]
	kRailSpaceWorkStateNone = 0,
	[Token(Token = "0x4001523")]
	kRailSpaceWorkStateDownloaded = 1,
	[Token(Token = "0x4001524")]
	kRailSpaceWorkStateNeedsSync = 2,
	[Token(Token = "0x4001525")]
	kRailSpaceWorkStateDownloading = 4,
	[Token(Token = "0x4001526")]
	kRailSpaceWorkStateUploading = 8
}
