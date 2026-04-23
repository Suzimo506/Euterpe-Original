using System;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[Token(Token = "0x200051E")]
[Flags]
public enum DirtyType : ulong
{
	[Token(Token = "0x4001D01")]
	None = 0uL,
	[Token(Token = "0x4001D02")]
	AllData = 1uL,
	[Token(Token = "0x4001D03")]
	Language = 2uL,
	[Token(Token = "0x4001D04")]
	LevelUp = 4uL,
	[Token(Token = "0x4001D05")]
	AnchorChange = 8uL,
	[Token(Token = "0x4001D06")]
	BuyAlbum = 0x10uL,
	[Token(Token = "0x4001D07")]
	UserChanged = 0x20uL,
	[Token(Token = "0x4001D08")]
	UserDirtyTypeStart = 0x80000000uL,
	[Token(Token = "0x4001D09")]
	All = ulong.MaxValue
}
