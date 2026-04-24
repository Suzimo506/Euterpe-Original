using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000522")]
public struct SfxDefine
{
	[Token(Token = "0x4001D17")]
	public const string normal_empty_atk = "char_common_empty_atk";

	[Token(Token = "0x4001D18")]
	public const string taoist_empty_atk = "char_exorcist_empty_atk";
}
