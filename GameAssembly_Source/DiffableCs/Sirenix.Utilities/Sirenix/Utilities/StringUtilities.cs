namespace Sirenix.Utilities;

[Extension]
public static class StringUtilities
{

	[Extension]
	public static bool FastEndsWith(string str, string endsWith) { }

	public static string NicifyByteSize(int bytes, int decimals = 1) { }

	public static int NumberAwareStringCompare(string a, string b, bool ignoreLeadingZeroes = true, bool ignoreWhiteSpace = true, bool ignoreCase = false) { }

}

