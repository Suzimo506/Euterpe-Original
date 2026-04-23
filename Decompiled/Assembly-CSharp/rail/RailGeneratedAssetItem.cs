using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200027C")]
public class RailGeneratedAssetItem
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000FFD")]
	public ulong container_id;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000FFE")]
	public uint product_id;

	[Token(Token = "0x4000FFF")]
	[FieldOffset(Offset = "0x20")]
	public RailAssetItem asset;

	[Token(Token = "0x6002CB7")]
	[Address(RVA = "0x2720730", Offset = "0x271EF30", Length = "0x64")]
	public RailGeneratedAssetItem()
	{
	}
}
