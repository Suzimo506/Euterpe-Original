using Cpp2ILInjected;
using Spine;

namespace GameLogic;

[Token(Token = "0x20004A0")]
public class NormalNodeOnAttacked : DoNothing
{
	[Token(Token = "0x60034CE")]
	[Address(RVA = "0x5D4DA0", Offset = "0x5D35A0", Length = "0x13F")]
	public override void Do(TrackEntry entry)
	{
	}

	[Token(Token = "0x60034CF")]
	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	public NormalNodeOnAttacked()
	{
	}
}
