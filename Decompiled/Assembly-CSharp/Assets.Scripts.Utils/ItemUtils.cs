using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;

namespace Assets.Scripts.Utils;

[Token(Token = "0x20005A8")]
public static class ItemUtils
{
	[Token(Token = "0x60038F2")]
	[Address(RVA = "0x5FC680", Offset = "0x5FAE80", Length = "0x270")]
	public static int chipAmount(this IData data)
	{
		return default(int);
	}

	[Address(RVA = "0x5FC4C0", Offset = "0x5FACC0", Length = "0x1BE")]
	[Token(Token = "0x60038F3")]
	public static string Rarity(this IData data)
	{
		return null;
	}

	[Token(Token = "0x60038F4")]
	[Address(RVA = "0x5FC440", Offset = "0x5FAC40", Length = "0x79")]
	public static bool IsUnlock(this IData data)
	{
		return default(bool);
	}

	[Token(Token = "0x60038F5")]
	[Address(RVA = "0x5FC1B0", Offset = "0x5FA9B0", Length = "0x28F")]
	public static bool IsHide(this IData data)
	{
		return default(bool);
	}

	[Token(Token = "0x60038F6")]
	[Address(RVA = "0x5FBF20", Offset = "0x5FA720", Length = "0x28C")]
	public static bool IsFree(this IData data)
	{
		return default(bool);
	}
}
