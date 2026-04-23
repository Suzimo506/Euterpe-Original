using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003D4")]
public class RailImageDataDescriptor
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40015B7")]
	public EnumRailImagePixelFormat pixel_format;

	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40015B8")]
	public uint image_height;

	[Token(Token = "0x40015B9")]
	[FieldOffset(Offset = "0x18")]
	public uint stride_in_bytes;

	[Token(Token = "0x40015BA")]
	[FieldOffset(Offset = "0x1C")]
	public uint image_width;

	[Token(Token = "0x40015BB")]
	[FieldOffset(Offset = "0x20")]
	public uint bits_per_pixel;

	[Token(Token = "0x6002F8C")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public RailImageDataDescriptor()
	{
	}
}
