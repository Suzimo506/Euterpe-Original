using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000311")]
public class RailInGamePurchaseRequestAllProductsResponse : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001256")]
	public List<RailPurchaseProductInfo> all_products;

	[Token(Token = "0x6002DFB")]
	[Address(RVA = "0x2720AE0", Offset = "0x271F2E0", Length = "0x69")]
	public RailInGamePurchaseRequestAllProductsResponse()
	{
	}
}
