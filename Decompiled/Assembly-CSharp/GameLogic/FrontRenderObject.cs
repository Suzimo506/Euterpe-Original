using Cpp2ILInjected;
using Spine;

namespace GameLogic;

[Token(Token = "0x200049D")]
public class FrontRenderObject : DoNothing
{
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60034C7")]
	public override void Do(TrackEntry entry)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60034C8")]
	public FrontRenderObject()
	{
	}
}
