using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000312")]
public class RailInGamePurchaseRequestAllPurchasableProductsResponse : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001257")]
	public List<RailPurchaseProductInfo> purchasable_products;

	[Address(RVA = "0x2720B50", Offset = "0x271F350", Length = "0x69")]
	[Token(Token = "0x6002DFC")]
	public RailInGamePurchaseRequestAllPurchasableProductsResponse()
	{
	}
}
