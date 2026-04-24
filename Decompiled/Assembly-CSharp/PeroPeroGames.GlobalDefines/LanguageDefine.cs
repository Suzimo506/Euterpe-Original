using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000523")]
public struct LanguageDefine
{
	[Token(Token = "0x4001D19")]
	public const string chineseS = "ChineseS";

	[Token(Token = "0x4001D1A")]
	public const string chineseT = "ChineseT";

	[Token(Token = "0x4001D1B")]
	public const string english = "English";

	[Token(Token = "0x4001D1C")]
	public const string japanese = "Japanese";

	[Token(Token = "0x4001D1D")]
	public const string korean = "Korean";
}
