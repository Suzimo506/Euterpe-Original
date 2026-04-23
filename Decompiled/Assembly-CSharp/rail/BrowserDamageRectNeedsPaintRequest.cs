using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000287")]
public class BrowserDamageRectNeedsPaintRequest : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400100C")]
	public uint update_bgra_height;

	[Token(Token = "0x400100D")]
	[FieldOffset(Offset = "0x34")]
	public uint scroll_x_pos;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400100E")]
	public string bgra_data;

	[Token(Token = "0x400100F")]
	[FieldOffset(Offset = "0x40")]
	public uint update_bgra_width;

	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4001010")]
	public float page_scale_factor;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001011")]
	public int update_offset_y;

	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4001012")]
	public int update_offset_x;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001013")]
	public int offset_x;

	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4001014")]
	public int offset_y;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001015")]
	public uint bgra_height;

	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4001016")]
	public uint scroll_y_pos;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001017")]
	public uint bgra_width;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002CE2")]
	public BrowserDamageRectNeedsPaintRequest()
	{
	}
}
