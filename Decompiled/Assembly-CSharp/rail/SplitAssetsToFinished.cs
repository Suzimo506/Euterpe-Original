using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000280")]
public class SplitAssetsToFinished : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001006")]
	public ulong source_asset;

	[Token(Token = "0x4001007")]
	[FieldOffset(Offset = "0x38")]
	public uint to_quantity;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001008")]
	public ulong split_to_asset_id;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002CBB")]
	public SplitAssetsToFinished()
	{
	}
}
