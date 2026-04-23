using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000317")]
public class RailInGameStorePurchasePayWindowDisplayed : EventBase
{
	[Token(Token = "0x4001265")]
	[FieldOffset(Offset = "0x30")]
	public string order_id;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002E01")]
	public RailInGameStorePurchasePayWindowDisplayed()
	{
	}
}
