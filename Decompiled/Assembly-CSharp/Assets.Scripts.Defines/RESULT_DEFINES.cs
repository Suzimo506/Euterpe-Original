using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Assets.Scripts.Defines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000780")]
public struct RESULT_DEFINES
{
	[Token(Token = "0x40027A4")]
	public const byte NONE = 0;

	[Token(Token = "0x40027A5")]
	public const byte MISS = 1;

	[Token(Token = "0x40027A6")]
	public const byte COOL = 2;

	[Token(Token = "0x40027A7")]
	public const byte GREAT = 3;

	[Token(Token = "0x40027A8")]
	public const byte PERFECT = 4;

	[Token(Token = "0x40027A9")]
	public const byte JUMPOVER = 5;

	[Token(Token = "0x40027AA")]
	public const byte FEVER = 6;
}
