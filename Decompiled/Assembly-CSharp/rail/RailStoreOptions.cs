using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002BA")]
public class RailStoreOptions
{
	[Token(Token = "0x4001191")]
	[FieldOffset(Offset = "0x10")]
	public int window_margin_top;

	[Token(Token = "0x4001192")]
	[FieldOffset(Offset = "0x14")]
	public int window_margin_left;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001193")]
	public EnumRailStoreType store_type;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002D3E")]
	public RailStoreOptions()
	{
	}
}
