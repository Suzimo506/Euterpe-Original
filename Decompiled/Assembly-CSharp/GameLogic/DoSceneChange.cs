using Cpp2ILInjected;
using Spine;

namespace GameLogic;

[Token(Token = "0x200049C")]
public class DoSceneChange : DoNothing
{
	[Token(Token = "0x60034C5")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void Do(TrackEntry entry)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60034C6")]
	public DoSceneChange()
	{
	}
}
