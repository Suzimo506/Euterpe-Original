using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000385")]
public enum EnumRailStreamOpenFileType
{
	[Token(Token = "0x40014CA")]
	kRailStreamOpenFileTypeReadOnly,
	[Token(Token = "0x40014CB")]
	kRailStreamOpenFileTypeTruncateWrite,
	[Token(Token = "0x40014CC")]
	kRailStreamOpenFileTypeAppendWrite
}
