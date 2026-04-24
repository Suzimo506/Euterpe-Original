using Cpp2ILInjected;
using Spine;

namespace GameLogic;

[Token(Token = "0x20004A3")]
public class OnNormalAttack : DoNothing
{
	[Token(Token = "0x60034D8")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void Do(TrackEntry entry)
	{
	}

	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	[Token(Token = "0x60034D9")]
	public OnNormalAttack()
	{
	}
}
