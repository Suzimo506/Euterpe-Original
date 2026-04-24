using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000510")]
public struct DifficultyDefine
{
	[Token(Token = "0x4001C7A")]
	public const string none = "0";

	[Token(Token = "0x4001C7B")]
	public const int easy = 1;

	[Token(Token = "0x4001C7C")]
	public const int normal = 2;

	[Token(Token = "0x4001C7D")]
	public const int master = 3;

	[Token(Token = "0x4001C7E")]
	public const int hide = 4;

	[Token(Token = "0x4001C7F")]
	public const int spell = 5;
}
