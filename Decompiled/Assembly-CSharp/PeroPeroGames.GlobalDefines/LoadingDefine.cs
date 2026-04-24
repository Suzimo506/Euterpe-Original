using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000500")]
public struct LoadingDefine
{
	[Token(Token = "0x4001B43")]
	public const int other = 0;

	[Token(Token = "0x4001B44")]
	public const int fourToThreeLoading = 1;

	[Token(Token = "0x4001B45")]
	public const int specialLoading = 2;

	[Token(Token = "0x4001B46")]
	public const int simpleSpecialLoading = 3;

	[Token(Token = "0x4001B47")]
	public const int squareLoading = 4;
}
