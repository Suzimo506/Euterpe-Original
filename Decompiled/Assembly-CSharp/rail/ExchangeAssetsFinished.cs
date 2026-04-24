using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000274")]
public class ExchangeAssetsFinished : EventBase
{
	[Token(Token = "0x4000FE5")]
	[FieldOffset(Offset = "0x30")]
	public List<RailAssetItem> old_assets;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000FE6")]
	public List<RailGeneratedAssetItem> new_asset_item_list;

	[Address(RVA = "0xD1FF30", Offset = "0xD1E730", Length = "0x96")]
	[Token(Token = "0x6002CAF")]
	public ExchangeAssetsFinished()
	{
	}
}
