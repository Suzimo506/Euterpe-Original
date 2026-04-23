using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000521")]
public struct DiscoActivityDefine
{
	[Token(Token = "0x4001D14")]
	public const int Radio = 0;

	[Token(Token = "0x4001D15")]
	public const int Dynamic = 1;

	[Token(Token = "0x4001D16")]
	public const int Melody = 2;
}
