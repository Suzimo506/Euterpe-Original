namespace Sirenix.Utilities;

[Extension]
public static class StringExtensions
{

	[Extension]
	public static bool Contains(string source, string toCheck, StringComparison comparisonType) { }

	[Extension]
	public static bool IsNullOrWhitespace(string str) { }

	[Extension]
	public static string SplitPascalCase(string input) { }

	[Extension]
	public static string ToTitleCase(string input) { }

}

