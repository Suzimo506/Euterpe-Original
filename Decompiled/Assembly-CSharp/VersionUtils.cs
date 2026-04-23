using Cpp2ILInjected;

[Token(Token = "0x20001B1")]
public static class VersionUtils
{
	[Address(RVA = "0x4EC020", Offset = "0x4EA820", Length = "0x20D")]
	[Token(Token = "0x6000C1E")]
	private static bool TryParseVersion(string version, out int[] outVersion)
	{
		outVersion = null;
		return default(bool);
	}

	[Token(Token = "0x6000C1F")]
	[Address(RVA = "0x4EBC60", Offset = "0x4EA460", Length = "0x7F")]
	private static int CompareVersions(int[] version1, int[] version2, bool compareMinor = true)
	{
		return default(int);
	}

	[Token(Token = "0x6000C20")]
	[Address(RVA = "0x4EBE20", Offset = "0x4EA620", Length = "0x17C")]
	public static bool IsVersionInRange(string version, string min, string max, bool compareMinor = true)
	{
		return default(bool);
	}

	[Address(RVA = "0x4EBD80", Offset = "0x4EA580", Length = "0x9E")]
	[Token(Token = "0x6000C21")]
	public static bool IsVersionGreaterThan(int[] version, int[] target, bool compareMinor = true)
	{
		return default(bool);
	}

	[Address(RVA = "0x4EBFA0", Offset = "0x4EA7A0", Length = "0x72")]
	[Token(Token = "0x6000C22")]
	public static bool IsVersionLessThan(int[] version, int[] target, bool compareMinor = true)
	{
		return default(bool);
	}

	[Address(RVA = "0x4EBCE0", Offset = "0x4EA4E0", Length = "0x9E")]
	[Token(Token = "0x6000C23")]
	public static bool IsVersionEqual(int[] version, int[] target, bool compareMinor = true)
	{
		return default(bool);
	}
}
