namespace Assets.Scripts.PeroTools.Commons.Google;

public static class GoogleLanguages
{
	internal struct LanguageCodeDef
	{
		public string Code; //Field offset: 0x0
		public string GoogleCode; //Field offset: 0x8

	}

	public static Dictionary<String, String> languageCodes; //Field offset: 0x0
	public static Dictionary<String, LanguageCodeDef> mLanguageDef; //Field offset: 0x8

	private static GoogleLanguages() { }

	public static List<String> GetAllInternationalCodes() { }

	public static string GetClosestLanguage(string Filter) { }

	public static string GetCodedLanguage(string Language, string code) { }

	public static string GetFormatedLanguageName(string Language) { }

	public static string GetGoogleLanguageCode(string internationalCode) { }

	public static string GetLanguageCode(string Filter, bool ShowWarnings = false) { }

	public static List<String> GetLanguagesForDropdown(string Filter, string CodesToExclude) { }

	private static bool LanguageMatchesFilter(string Language, String[] Filters) { }

	public static void UnPackCodeFromLanguageName(string CodedLanguage, out string Language, out string code) { }

}

