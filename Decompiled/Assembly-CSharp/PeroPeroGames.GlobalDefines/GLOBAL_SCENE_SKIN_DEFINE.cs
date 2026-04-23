using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000508")]
public struct GLOBAL_SCENE_SKIN_DEFINE
{
	[Token(Token = "0x4001B66")]
	public const int normal = 0;

	[Token(Token = "0x4001B67")]
	public const int bad_apple = 1;
}
