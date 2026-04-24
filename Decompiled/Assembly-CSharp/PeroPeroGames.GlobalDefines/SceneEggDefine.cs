using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000516")]
public struct SceneEggDefine
{
	[Token(Token = "0x4001CAF")]
	public const int cytus = 0;

	[Token(Token = "0x4001CB0")]
	public const int wacca = 1;

	[Token(Token = "0x4001CB1")]
	public const int leaf = 2;

	[Token(Token = "0x4001CB2")]
	public const int touhou = 3;

	[Token(Token = "0x4001CB3")]
	public const int arknight = 4;

	[Token(Token = "0x4001CB4")]
	public const int christmas = 999;
}
