using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200027F")]
public class SplitAssetsFinished : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001003")]
	public ulong source_asset;

	[Token(Token = "0x4001004")]
	[FieldOffset(Offset = "0x38")]
	public uint to_quantity;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001005")]
	public ulong new_asset_id;

	[Token(Token = "0x6002CBA")]
	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	public SplitAssetsFinished()
	{
	}
}
