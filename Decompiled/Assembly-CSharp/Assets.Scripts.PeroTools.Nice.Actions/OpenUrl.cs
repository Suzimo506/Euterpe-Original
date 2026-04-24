using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x2000621")]
public class OpenUrl : Action
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002278")]
	[Attribute(Name = "VariableAttribute", RVA = "0x14AD0", Offset = "0x13ED0")]
	public IVariable url;

	[Token(Token = "0x6003B7C")]
	[Address(RVA = "0x745950", Offset = "0x744150", Length = "0x43")]
	public override void Execute()
	{
	}

	[Token(Token = "0x6003B7D")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public OpenUrl()
	{
	}
}
