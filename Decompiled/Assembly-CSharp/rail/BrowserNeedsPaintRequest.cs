using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000288")]
public class BrowserNeedsPaintRequest : EventBase
{
	[Token(Token = "0x4001018")]
	[FieldOffset(Offset = "0x30")]
	public uint bgra_width;

	[Token(Token = "0x4001019")]
	[FieldOffset(Offset = "0x34")]
	public uint scroll_y_pos;

	[Token(Token = "0x400101A")]
	[FieldOffset(Offset = "0x38")]
	public string bgra_data;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400101B")]
	public float page_scale_factor;

	[Token(Token = "0x400101C")]
	[FieldOffset(Offset = "0x44")]
	public int offset_x;

	[Token(Token = "0x400101D")]
	[FieldOffset(Offset = "0x48")]
	public uint scroll_x_pos;

	[Token(Token = "0x400101E")]
	[FieldOffset(Offset = "0x4C")]
	public uint bgra_height;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400101F")]
	public int offset_y;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002CE3")]
	public BrowserNeedsPaintRequest()
	{
	}
}
