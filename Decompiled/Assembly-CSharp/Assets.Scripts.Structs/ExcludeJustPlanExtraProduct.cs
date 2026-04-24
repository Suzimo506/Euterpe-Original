using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Structs;

[Token(Token = "0x2000578")]
internal static class ExcludeJustPlanExtraProduct
{
	[Token(Token = "0x4002048")]
	public static readonly List<CheckRoleItemParams> productContent;

	[Token(Token = "0x4002049")]
	public static readonly List<CheckExcludeAlbumProduct> discountContent;

	[Token(Token = "0x6003863")]
	[Address(RVA = "0x655670", Offset = "0x653E70", Length = "0x129")]
	public static bool IsMusicPackageExcludeJustAsPlanned(string uid)
	{
		return default(bool);
	}

	[Obsolete]
	[Address(RVA = "0x654D20", Offset = "0x653520", Length = "0x191")]
	[Token(Token = "0x6003864")]
	public static bool IsCharacterExcludeJustAsPlanned(int roleIndex)
	{
		return default(bool);
	}

	[Obsolete]
	[Address(RVA = "0x654EC0", Offset = "0x6536C0", Length = "0x198")]
	[Token(Token = "0x6003865")]
	public static bool IsElfinExcludeJustAsPlanned(int elfinIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6003866")]
	[Address(RVA = "0x6554C0", Offset = "0x653CC0", Length = "0x1A2")]
	[Obsolete]
	public static bool IsLoadingExcludeJustAsPlanned(int loadingIndex)
	{
		return default(bool);
	}

	[Address(RVA = "0x6557A0", Offset = "0x653FA0", Length = "0x191")]
	[Token(Token = "0x6003867")]
	[Obsolete]
	public static bool IsWelcomeExcludeJustAsPlanned(int welcomeIndex)
	{
		return default(bool);
	}

	[Address(RVA = "0x655060", Offset = "0x653860", Length = "0x198")]
	[Token(Token = "0x6003868")]
	public static bool IsFeverIndexExcludeJustAsPlanned(int feverIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6003869")]
	[Address(RVA = "0x655200", Offset = "0x653A00", Length = "0x2B8")]
	public static bool IsItemExcludeJustAsPlanned(string type, int itemIndex)
	{
		return default(bool);
	}
}
