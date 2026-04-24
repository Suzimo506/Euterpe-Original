using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000276")]
public class MergeAssetsFinished : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000FEA")]
	public List<RailAssetItem> source_assets;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000FEB")]
	public ulong new_asset_id;

	[Token(Token = "0x6002CB1")]
	[Address(RVA = "0x37E4B0", Offset = "0x37CCB0", Length = "0x69")]
	public MergeAssetsFinished()
	{
	}
}
