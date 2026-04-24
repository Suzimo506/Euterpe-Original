using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x200050F")]
public struct Language
{
	[Token(Token = "0x4001C73")]
	public const int none = 0;

	[Token(Token = "0x4001C74")]
	public const int english = 1;

	[Token(Token = "0x4001C75")]
	public const int chineses = 2;

	[Token(Token = "0x4001C76")]
	public const int chineset = 3;

	[Token(Token = "0x4001C77")]
	public const int japanese = 4;

	[Token(Token = "0x4001C78")]
	public const int korean = 5;

	[Token(Token = "0x4001C79")]
	public const int language_count = 6;

	[Address(RVA = "0x4F57A0", Offset = "0x4F3FA0", Length = "0xEE")]
	[Token(Token = "0x600372F")]
	public static int LanguageToIndex(string lang)
	{
		return default(int);
	}

	[Token(Token = "0x6003730")]
	[Address(RVA = "0x4F56A0", Offset = "0x4F3EA0", Length = "0xF0")]
	public static string IndexToLanguage(int langIdx)
	{
		return null;
	}
}
