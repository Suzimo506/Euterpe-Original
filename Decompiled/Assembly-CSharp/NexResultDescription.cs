using Cpp2ILInjected;

[Token(Token = "0x2000085")]
public class NexResultDescription
{
	[Token(Token = "0x20009C9")]
	public enum ErrorType
	{
		[Token(Token = "0x40034FF")]
		None,
		[Token(Token = "0x4003500")]
		Logout,
		[Token(Token = "0x4003501")]
		Busy,
		[Token(Token = "0x4003502")]
		NoNet,
		[Token(Token = "0x4003503")]
		NoNsa
	}

	[Token(Token = "0x4000383")]
	public static bool isUnknowError;

	[Address(RVA = "0x86B910", Offset = "0x86A110", Length = "0x6")]
	[Token(Token = "0x60003F7")]
	public static bool isSuccess(int des)
	{
		return default(bool);
	}

	[Address(RVA = "0x47F9A0", Offset = "0x47E1A0", Length = "0x3")]
	[Token(Token = "0x60003F8")]
	public static ErrorType GetErrorType(int des)
	{
		return default(ErrorType);
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60003F9")]
	public NexResultDescription()
	{
	}
}
