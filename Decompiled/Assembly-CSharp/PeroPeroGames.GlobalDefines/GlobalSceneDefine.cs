using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000504")]
public struct GlobalSceneDefine
{
	[Token(Token = "0x4001B57")]
	public const int space_station = 1;

	[Token(Token = "0x4001B58")]
	public const int retrocity = 2;

	[Token(Token = "0x4001B59")]
	public const int castle = 3;

	[Token(Token = "0x4001B5A")]
	public const int rainy_night = 4;

	[Token(Token = "0x4001B5B")]
	public const int candyland = 5;

	[Token(Token = "0x4001B5C")]
	public const int oriental = 6;

	[Token(Token = "0x4001B5D")]
	public const int groove_coaster = 7;

	[Token(Token = "0x4001B5E")]
	public const int touhou = 8;

	[Token(Token = "0x4001B5F")]
	public const int dj_max = 9;

	[Token(Token = "0x4001B60")]
	public const int miku = 10;
}
