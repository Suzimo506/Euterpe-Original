using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000503")]
public struct VipUnlockItemDefine
{
	[Token(Token = "0x4001B54")]
	public const string character = "character";

	[Token(Token = "0x4001B55")]
	public const string elfin = "elfin";

	[Token(Token = "0x4001B56")]
	public const string album = "album";
}
