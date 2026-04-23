using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000531")]
public struct SCENE_DEFINES
{
	[Token(Token = "0x4001F23")]
	public const int scene_count = 9;

	[Token(Token = "0x4001F24")]
	public const int groove_coaster = 7;

	[Token(Token = "0x4001F25")]
	public const int dj_max = 9;

	[Token(Token = "0x4001F26")]
	public static readonly Dictionary<string, int> SCENE_INFO;
}
