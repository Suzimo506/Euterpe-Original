using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x200061F")]
public class Loop : Group
{
	[Token(Token = "0x17000587")]
	public override float duration
	{
		[Token(Token = "0x6003B78")]
		[Address(RVA = "0x745850", Offset = "0x744050", Length = "0x9")]
		get
		{
			return default(float);
		}
	}

	[Address(RVA = "0x7456E0", Offset = "0x743EE0", Length = "0x16B")]
	[Token(Token = "0x6003B79")]
	public override void Execute()
	{
	}

	[Address(RVA = "0x745670", Offset = "0x743E70", Length = "0x7")]
	[Token(Token = "0x6003B7A")]
	public Loop()
	{
	}
}
