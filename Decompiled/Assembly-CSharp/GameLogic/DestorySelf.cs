using Cpp2ILInjected;
using Spine;

namespace GameLogic;

[Token(Token = "0x2000499")]
public class DestorySelf : DoNothing
{
	[Token(Token = "0x60034B6")]
	[Address(RVA = "0x8F5480", Offset = "0x8F3C80", Length = "0xA1")]
	public override void Do(TrackEntry entry)
	{
	}

	[Token(Token = "0x60034B7")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public DestorySelf()
	{
	}
}
