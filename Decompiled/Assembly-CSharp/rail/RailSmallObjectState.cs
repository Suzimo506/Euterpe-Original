using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000370")]
public class RailSmallObjectState
{
	[Token(Token = "0x40014A8")]
	[FieldOffset(Offset = "0x10")]
	public EnumRailSmallObjectUpdateState update_state;

	[Token(Token = "0x40014A9")]
	[FieldOffset(Offset = "0x14")]
	public uint index;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002EAA")]
	public RailSmallObjectState()
	{
	}
}
