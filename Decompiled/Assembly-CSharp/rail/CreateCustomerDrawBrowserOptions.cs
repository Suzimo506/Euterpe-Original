using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000290")]
public class CreateCustomerDrawBrowserOptions
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400102E")]
	public int content_offset_x;

	[Token(Token = "0x400102F")]
	[FieldOffset(Offset = "0x14")]
	public int content_offset_y;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001030")]
	public uint content_window_height;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001031")]
	public bool has_scroll;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001032")]
	public uint content_window_width;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002CEB")]
	public CreateCustomerDrawBrowserOptions()
	{
	}
}
