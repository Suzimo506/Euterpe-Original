using Cpp2ILInjected;

[Token(Token = "0x2000008")]
public class TextContentCheckUtility
{
	[Address(RVA = "0x51BD80", Offset = "0x51A580", Length = "0x59")]
	[Token(Token = "0x6000014")]
	public static bool CheckIsChineseMobilePhoneNumber(string phoneNumber)
	{
		return default(bool);
	}

	[Address(RVA = "0x51BDE0", Offset = "0x51A5E0", Length = "0x59")]
	[Token(Token = "0x6000015")]
	public static bool CheckIsEmail(string email)
	{
		return default(bool);
	}

	[Address(RVA = "0x51BE40", Offset = "0x51A640", Length = "0x59")]
	[Token(Token = "0x6000016")]
	public static bool CheckVerifyCode(string code)
	{
		return default(bool);
	}

	[Address(RVA = "0x51BF80", Offset = "0x51A780", Length = "0x60")]
	[Token(Token = "0x6000017")]
	public static string MaskMobileNumber(string phoneNumber)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x51BEA0", Offset = "0x51A6A0", Length = "0xD2")]
	public static string MaskEmailStr(string email)
	{
		return null;
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6000019")]
	public TextContentCheckUtility()
	{
	}
}
