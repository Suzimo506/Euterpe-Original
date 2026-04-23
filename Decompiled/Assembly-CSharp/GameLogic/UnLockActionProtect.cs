using Cpp2ILInjected;
using Spine;

namespace GameLogic;

[Token(Token = "0x20004A6")]
public class UnLockActionProtect : DoNothing
{
	[Token(Token = "0x60034DE")]
	[Address(RVA = "0x5D6850", Offset = "0x5D5050", Length = "0x93")]
	public override void Do(TrackEntry entry)
	{
	}

	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	[Token(Token = "0x60034DF")]
	public UnLockActionProtect()
	{
	}
}
