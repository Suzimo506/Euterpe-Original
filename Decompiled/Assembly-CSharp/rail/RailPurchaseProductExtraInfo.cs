using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000313")]
public class RailPurchaseProductExtraInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001258")]
	public string bundle_rule;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001259")]
	public string exchange_rule;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002DFD")]
	public RailPurchaseProductExtraInfo()
	{
	}
}
