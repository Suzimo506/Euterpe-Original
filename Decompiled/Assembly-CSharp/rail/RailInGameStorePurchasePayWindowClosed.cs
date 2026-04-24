using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000316")]
public class RailInGameStorePurchasePayWindowClosed : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001264")]
	public string order_id;

	[Token(Token = "0x6002E00")]
	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	public RailInGameStorePurchasePayWindowClosed()
	{
	}
}
