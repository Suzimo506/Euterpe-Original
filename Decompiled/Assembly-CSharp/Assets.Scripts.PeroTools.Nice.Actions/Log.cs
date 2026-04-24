using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x200061E")]
public class Log : Action
{
	[Token(Token = "0x4002277")]
	[FieldOffset(Offset = "0x10")]
	public string message;

	[Address(RVA = "0x745680", Offset = "0x743E80", Length = "0x55")]
	[Token(Token = "0x6003B76")]
	public override void Execute()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003B77")]
	public Log()
	{
	}
}
