using Cpp2ILInjected;
using Spine;

namespace GameLogic;

[Token(Token = "0x200049A")]
public class DoLogin : DoNothing
{
	[Token(Token = "0x60034B8")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void Do(TrackEntry entry)
	{
	}

	[Token(Token = "0x60034B9")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public DoLogin()
	{
	}
}
