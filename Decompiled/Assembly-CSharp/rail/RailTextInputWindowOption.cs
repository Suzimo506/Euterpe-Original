using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000395")]
public class RailTextInputWindowOption
{
	[Token(Token = "0x40014EE")]
	[FieldOffset(Offset = "0x10")]
	public bool enable_multi_line_edit;

	[Token(Token = "0x40014EF")]
	[FieldOffset(Offset = "0x18")]
	public string description;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40014F0")]
	public uint position_top;

	[Token(Token = "0x40014F1")]
	[FieldOffset(Offset = "0x24")]
	public uint position_left;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40014F2")]
	public string caption_text;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40014F3")]
	public bool show_password_input;

	[Token(Token = "0x40014F4")]
	[FieldOffset(Offset = "0x31")]
	public bool is_min_window;

	[Token(Token = "0x40014F5")]
	[FieldOffset(Offset = "0x38")]
	public string content_placeholder;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40014F6")]
	public bool auto_cancel;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002F00")]
	public RailTextInputWindowOption()
	{
	}
}
