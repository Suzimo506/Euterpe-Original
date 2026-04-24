using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x200063B")]
public class StopMusic : Action
{
	[Address(RVA = "0x74EB50", Offset = "0x74D350", Length = "0x43")]
	[Token(Token = "0x6003BF4")]
	public override void Execute()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003BF5")]
	public StopMusic()
	{
	}
}
