using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200028E")]
public class CreateBrowserOptions
{
	[Token(Token = "0x4001027")]
	[FieldOffset(Offset = "0x10")]
	public bool allow_alternate_external_browser;

	[Token(Token = "0x4001028")]
	[FieldOffset(Offset = "0x11")]
	public bool has_minimum_button;

	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x4001029")]
	public bool has_border;

	[FieldOffset(Offset = "0x13")]
	[Token(Token = "0x400102A")]
	public bool is_movable;

	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400102B")]
	public bool has_maximum_button;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400102C")]
	public int margin_left;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400102D")]
	public int margin_top;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002CE9")]
	public CreateBrowserOptions()
	{
	}
}
