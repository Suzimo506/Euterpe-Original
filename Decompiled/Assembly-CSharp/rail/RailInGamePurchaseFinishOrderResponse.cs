using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200030E")]
public class RailInGamePurchaseFinishOrderResponse : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001251")]
	public string order_id;

	[Token(Token = "0x6002DF8")]
	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	public RailInGamePurchaseFinishOrderResponse()
	{
	}
}
