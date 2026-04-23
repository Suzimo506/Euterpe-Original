using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Assets.Scripts.Utils;

[Token(Token = "0x20005AB")]
public static class StringUtils
{
	[Address(RVA = "0x603900", Offset = "0x602100", Length = "0x4D5")]
	[Token(Token = "0x6003912")]
	public static string GetOriginalProductId(this string productId)
	{
		return null;
	}

	[Address(RVA = "0x603DE0", Offset = "0x6025E0", Length = "0x5B")]
	[Token(Token = "0x6003913")]
	public static bool IsCollectionBundle(this string productId)
	{
		return default(bool);
	}

	[Address(RVA = "0x603F00", Offset = "0x602700", Length = "0x5B")]
	[Token(Token = "0x6003914")]
	public static bool IsMusicPackage(this string productId)
	{
		return default(bool);
	}

	[Token(Token = "0x6003915")]
	[Address(RVA = "0x603E40", Offset = "0x602640", Length = "0xB7")]
	public static bool IsMusicPackageWithDiscount(this string productId)
	{
		return default(bool);
	}

	[Address(RVA = "0x604080", Offset = "0x602880", Length = "0x17E")]
	[Token(Token = "0x6003916")]
	public static bool TryGetMusicPackageDiscount(this string input, out int discount)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref discount) = null;
		return default(bool);
	}

	[Address(RVA = "0x603830", Offset = "0x602030", Length = "0xCB")]
	[Token(Token = "0x6003917")]
	public static int GetMusicPackageId(this string input)
	{
		return default(int);
	}

	[Address(RVA = "0x603FC0", Offset = "0x6027C0", Length = "0x5B")]
	[Token(Token = "0x6003918")]
	public static bool IsUnlockAll(this string productId)
	{
		return default(bool);
	}

	[Address(RVA = "0x604020", Offset = "0x602820", Length = "0x5B")]
	[Token(Token = "0x6003919")]
	public static bool IsVip(this string productId)
	{
		return default(bool);
	}

	[Address(RVA = "0x603F60", Offset = "0x602760", Length = "0x5B")]
	[Token(Token = "0x600391A")]
	public static bool IsUnlockAll29(this string productId)
	{
		return default(bool);
	}
}
