using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000502")]
public struct ItemTypeDefine
{
	[Token(Token = "0x4001B4F")]
	public const string character = "character";

	[Token(Token = "0x4001B50")]
	public const string elfin = "elfin";

	[Token(Token = "0x4001B51")]
	public const string loading = "loading";

	[Token(Token = "0x4001B52")]
	public const string welcome = "welcome";

	[Token(Token = "0x4001B53")]
	public const string fever = "fever";
}
