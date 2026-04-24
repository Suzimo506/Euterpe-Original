using System;
using Account;
using Cpp2ILInjected;

namespace Assets.Scripts.UI;

[Token(Token = "0x200081D")]
public static class AccountSaveUtils
{
	[Token(Token = "0x6004AEA")]
	[Address(RVA = "0x5A4610", Offset = "0x5A2E10", Length = "0x14")]
	public static int CacularLevel(int exp)
	{
		return default(int);
	}

	[Token(Token = "0x6004AEB")]
	[Address(RVA = "0x5A45F0", Offset = "0x5A2DF0", Length = "0x19")]
	public static int CacularCurExp(int exp)
	{
		return default(int);
	}

	[Token(Token = "0x6004AEC")]
	[Address(RVA = "0x5A4630", Offset = "0x5A2E30", Length = "0x6A2")]
	public static string FormatRemainDate(DateTime srcDateTime, DateTime lastSaveTime)
	{
		return null;
	}

	[Token(Token = "0x6004AED")]
	[Address(RVA = "0x5A4CE0", Offset = "0x5A34E0", Length = "0xA4")]
	public static string GetLoginPlatform(AccountPlatform platformEunm)
	{
		return null;
	}
}
