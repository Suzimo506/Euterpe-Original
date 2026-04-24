using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200030F")]
public class RailInGamePurchasePurchaseProductsResponse : EventBase
{
	[Token(Token = "0x4001252")]
	[FieldOffset(Offset = "0x30")]
	public string order_id;

	[Token(Token = "0x4001253")]
	[FieldOffset(Offset = "0x38")]
	public List<RailProductItem> delivered_products;

	[Token(Token = "0x6002DF9")]
	[Address(RVA = "0x2720A00", Offset = "0x271F200", Length = "0x69")]
	public RailInGamePurchasePurchaseProductsResponse()
	{
	}
}
