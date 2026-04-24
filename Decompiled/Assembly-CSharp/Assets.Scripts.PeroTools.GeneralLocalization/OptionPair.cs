using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.GeneralLocalization;

[Token(Token = "0x200065A")]
public class OptionPair
{
	[Token(Token = "0x40023B8")]
	[FieldOffset(Offset = "0x10")]
	public Option option;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40023B9")]
	public OptionEntry optionEntry;

	[Token(Token = "0x6003D3A")]
	[Address(RVA = "0x760D80", Offset = "0x75F580", Length = "0x84")]
	public OptionPair()
	{
	}
}
