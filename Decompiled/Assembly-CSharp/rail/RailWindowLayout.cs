using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002BC")]
public class RailWindowLayout
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001198")]
	public uint x_margin;

	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001199")]
	public uint y_margin;

	[Token(Token = "0x400119A")]
	[FieldOffset(Offset = "0x18")]
	public EnumRailNotifyWindowPosition position_type;

	[Token(Token = "0x6002D3F")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public RailWindowLayout()
	{
	}
}
