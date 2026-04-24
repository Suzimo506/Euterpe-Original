using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000310")]
public class RailInGamePurchasePurchaseProductsToAssetsResponse : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001254")]
	public string order_id;

	[Token(Token = "0x4001255")]
	[FieldOffset(Offset = "0x38")]
	public List<RailAssetInfo> delivered_assets;

	[Token(Token = "0x6002DFA")]
	[Address(RVA = "0x2720A70", Offset = "0x271F270", Length = "0x69")]
	public RailInGamePurchasePurchaseProductsToAssetsResponse()
	{
	}
}
