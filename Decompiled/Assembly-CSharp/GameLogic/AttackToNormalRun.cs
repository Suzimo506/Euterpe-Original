using Cpp2ILInjected;
using Spine;

namespace GameLogic;

[Token(Token = "0x2000498")]
public class AttackToNormalRun : DoNothing
{
	[Token(Token = "0x60034B4")]
	[Address(RVA = "0x8F5160", Offset = "0x8F3960", Length = "0x21E")]
	public override void Do(TrackEntry entry)
	{
	}

	[Token(Token = "0x60034B5")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public AttackToNormalRun()
	{
	}
}
