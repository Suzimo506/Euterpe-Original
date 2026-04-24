using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000518")]
public struct FeverDefine
{
	[Token(Token = "0x4001CBD")]
	public const int fever_mode_default = 0;

	[Token(Token = "0x4001CBE")]
	public const int fever_mode_easy = 1;

	[Token(Token = "0x4001CBF")]
	public const int fever_default = 0;

	[Token(Token = "0x4001CC0")]
	public const int fever_christmas = 1;

	[Token(Token = "0x4001CC1")]
	public const int fever_fm104 = 2;

	[Token(Token = "0x4001CC2")]
	public const int fever_mutown = 3;

	[Token(Token = "0x4001CC3")]
	public const int fever_miku = 4;

	[Token(Token = "0x4001CC4")]
	public const int fever_tricks = 5;

	[Token(Token = "0x4001CC5")]
	public const int fever_feMeow = 6;
}
