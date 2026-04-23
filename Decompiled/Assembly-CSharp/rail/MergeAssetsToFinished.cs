using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000277")]
public class MergeAssetsToFinished : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000FEC")]
	public ulong merge_to_asset_id;

	[Token(Token = "0x4000FED")]
	[FieldOffset(Offset = "0x38")]
	public List<RailAssetItem> source_assets;

	[Address(RVA = "0x37E520", Offset = "0x37CD20", Length = "0x69")]
	[Token(Token = "0x6002CB2")]
	public MergeAssetsToFinished()
	{
	}
}
