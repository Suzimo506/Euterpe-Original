using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000532")]
internal struct SkillTypeDefines
{
	[Token(Token = "0x4001F27")]
	public const int none = 0;

	[Token(Token = "0x4001F28")]
	public const int character = 1;

	[Token(Token = "0x4001F29")]
	public const int elfin = 2;
}
