using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000275")]
public class ExchangeAssetsToFinished : EventBase
{
	[Token(Token = "0x4000FE7")]
	[FieldOffset(Offset = "0x30")]
	public ulong exchange_to_asset_id;

	[Token(Token = "0x4000FE8")]
	[FieldOffset(Offset = "0x38")]
	public RailProductItem to_product_info;

	[Token(Token = "0x4000FE9")]
	[FieldOffset(Offset = "0x40")]
	public List<RailAssetItem> old_assets;

	[Address(RVA = "0xD1FFD0", Offset = "0xD1E7D0", Length = "0x91")]
	[Token(Token = "0x6002CB0")]
	public ExchangeAssetsToFinished()
	{
	}
}
