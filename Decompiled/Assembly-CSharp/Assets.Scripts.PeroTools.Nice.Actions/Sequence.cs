using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x200062E")]
public class Sequence : Group
{
	[Token(Token = "0x17000591")]
	public override float duration
	{
		[Token(Token = "0x6003BC8")]
		[Address(RVA = "0x74B460", Offset = "0x749C60", Length = "0xF3")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6003BC9")]
	[Address(RVA = "0x74B2F0", Offset = "0x749AF0", Length = "0x16B")]
	public override void Execute()
	{
	}

	[Address(RVA = "0x745670", Offset = "0x743E70", Length = "0x7")]
	[Token(Token = "0x6003BCA")]
	public Sequence()
	{
	}
}
