using System;
using Cpp2ILInjected;

namespace Assets.Scripts.Egg;

[Token(Token = "0x20006AB")]
public static class NekoEggLogic
{
	[Token(Token = "0x4002409")]
	private const string cat_egg_suffix = "_cat";

	[Token(Token = "0x400240A")]
	private static int[] s_SupportRoleIndexs;

	[Address(RVA = "0x4A1C50", Offset = "0x4A0450", Length = "0x68")]
	[Token(Token = "0x6003EA5")]
	public static bool CheckSupport(int roleIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6003EA6")]
	[Address(RVA = "0x4A1750", Offset = "0x49FF50", Length = "0x246")]
	public static void ASyncRefreshNekoEgg(DateTime chinaServerTime)
	{
	}

	[Token(Token = "0x6003EA7")]
	[Address(RVA = "0x4A1CC0", Offset = "0x4A04C0", Length = "0x391")]
	private static void FirstCatLogic()
	{
	}

	[Address(RVA = "0x4A19A0", Offset = "0x4A01A0", Length = "0x2A7")]
	[Token(Token = "0x6003EA8")]
	public static void CatLogic()
	{
	}
}
