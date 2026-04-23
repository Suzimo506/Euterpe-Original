using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000279")]
public class RailAssetItem
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000FF9")]
	public ulong asset_id;

	[Token(Token = "0x4000FFA")]
	[FieldOffset(Offset = "0x18")]
	public uint quantity;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002CB4")]
	public RailAssetItem()
	{
	}
}
