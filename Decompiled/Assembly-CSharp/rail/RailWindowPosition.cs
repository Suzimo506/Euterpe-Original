using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000302")]
public class RailWindowPosition
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400122D")]
	public uint position_top;

	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400122E")]
	public uint position_left;

	[Token(Token = "0x6002DE9")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public RailWindowPosition()
	{
	}
}
