using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000278")]
public class RailAssetInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000FEE")]
	public ulong asset_id;

	[Token(Token = "0x4000FEF")]
	[FieldOffset(Offset = "0x18")]
	public uint origin;

	[Token(Token = "0x4000FF0")]
	[FieldOffset(Offset = "0x1C")]
	public uint product_id;

	[Token(Token = "0x4000FF1")]
	[FieldOffset(Offset = "0x20")]
	public ulong container_id;

	[Token(Token = "0x4000FF2")]
	[FieldOffset(Offset = "0x28")]
	public uint flag;

	[Token(Token = "0x4000FF3")]
	[FieldOffset(Offset = "0x2C")]
	public uint state;

	[Token(Token = "0x4000FF4")]
	[FieldOffset(Offset = "0x30")]
	public string progress;

	[Token(Token = "0x4000FF5")]
	[FieldOffset(Offset = "0x38")]
	public uint expire_time;

	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000FF6")]
	public int position;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000FF7")]
	public string product_name;

	[Token(Token = "0x4000FF8")]
	[FieldOffset(Offset = "0x48")]
	public uint quantity;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002CB3")]
	public RailAssetInfo()
	{
	}
}
