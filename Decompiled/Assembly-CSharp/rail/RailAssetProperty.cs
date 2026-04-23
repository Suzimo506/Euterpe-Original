using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200027A")]
public class RailAssetProperty
{
	[Token(Token = "0x4000FFB")]
	[FieldOffset(Offset = "0x10")]
	public ulong asset_id;

	[Token(Token = "0x4000FFC")]
	[FieldOffset(Offset = "0x18")]
	public uint position;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002CB5")]
	public RailAssetProperty()
	{
	}
}
