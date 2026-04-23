using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Commons.Google;

[Token(Token = "0x20006A8")]
public static class GoogleLanguages
{
	[Token(Token = "0x2000C42")]
	public struct LanguageCodeDef
	{
		[Token(Token = "0x4003C8A")]
		[FieldOffset(Offset = "0x0")]
		public string Code;

		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4003C8B")]
		public string GoogleCode;
	}

	[Token(Token = "0x4002400")]
	public static Dictionary<string, string> languageCodes;

	[Token(Token = "0x4002401")]
	public static Dictionary<string, LanguageCodeDef> mLanguageDef;

	[Address(RVA = "0x927480", Offset = "0x925C80", Length = "0x283")]
	[Token(Token = "0x6003E90")]
	public static string GetLanguageCode(string Filter, bool ShowWarnings = false)
	{
		return null;
	}

	[Address(RVA = "0x927710", Offset = "0x925F10", Length = "0x428")]
	[Token(Token = "0x6003E91")]
	public static List<string> GetLanguagesForDropdown(string Filter, string CodesToExclude)
	{
		return null;
	}

	[Address(RVA = "0x926ED0", Offset = "0x9256D0", Length = "0x213")]
	[Token(Token = "0x6003E92")]
	public static string GetClosestLanguage(string Filter)
	{
		return null;
	}

	[Token(Token = "0x6003E93")]
	[Address(RVA = "0x927B40", Offset = "0x926340", Length = "0x171")]
	private static bool LanguageMatchesFilter(string Language, string[] Filters)
	{
		return default(bool);
	}

	[Token(Token = "0x6003E94")]
	[Address(RVA = "0x9271A0", Offset = "0x9259A0", Length = "0x101")]
	public static string GetFormatedLanguageName(string Language)
	{
		return null;
	}

	[Token(Token = "0x6003E95")]
	[Address(RVA = "0x9270F0", Offset = "0x9258F0", Length = "0xA7")]
	public static string GetCodedLanguage(string Language, string code)
	{
		return null;
	}

	[Token(Token = "0x6003E96")]
	[Address(RVA = "0x927CC0", Offset = "0x9264C0", Length = "0x171")]
	public static void UnPackCodeFromLanguageName(string CodedLanguage, out string Language, out string code)
	{
		Language = null;
		code = null;
	}

	[Address(RVA = "0x9272B0", Offset = "0x925AB0", Length = "0x1C0")]
	[Token(Token = "0x6003E97")]
	public static string GetGoogleLanguageCode(string internationalCode)
	{
		return null;
	}

	[Token(Token = "0x6003E98")]
	[Address(RVA = "0x926D50", Offset = "0x925550", Length = "0x172")]
	public static List<string> GetAllInternationalCodes()
	{
		return null;
	}
}
