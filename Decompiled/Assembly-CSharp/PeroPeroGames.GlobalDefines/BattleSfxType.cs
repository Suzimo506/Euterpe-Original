using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x200050E")]
public struct BattleSfxType
{
	[Token(Token = "0x4001C6D")]
	internal const int normal = 0;

	[Token(Token = "0x4001C6E")]
	internal const int neko = 1;

	[Token(Token = "0x4001C6F")]
	internal const int error = 2;

	[Token(Token = "0x4001C70")]
	internal const int mutown = 3;

	[Token(Token = "0x4001C71")]
	internal const int muscleman = 4;

	[Token(Token = "0x4001C72")]
	private static string[] s_BattleSfxSuffix;

	[Address(RVA = "0x4EE6E0", Offset = "0x4ECEE0", Length = "0x12B")]
	[Token(Token = "0x600372D")]
	public static string GetSfxSuffix(int index)
	{
		return null;
	}
}
