using Cpp2ILInjected;

[Token(Token = "0x2000061")]
public class ReviewSetting
{
	[Token(Token = "0x40002E2")]
	private const string setting_name_true = "review";

	[Token(Token = "0x40002E3")]
	private const string setting_name_false = "no_review";

	[Token(Token = "0x40002E4")]
	private static readonly string[] s_Others;

	[Address(RVA = "0x56C790", Offset = "0x56AF90", Length = "0x59A")]
	[Token(Token = "0x6000304")]
	public static void Apply()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public ReviewSetting()
	{
	}
}
