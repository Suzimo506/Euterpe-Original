using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.GeneralLocalization;

[Token(Token = "0x200065D")]
public class GlobalOptionPair
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40023BB")]
	public GlobalOptoin globalOption;

	[Token(Token = "0x40023BC")]
	[FieldOffset(Offset = "0x18")]
	public OptionEntry optionEntry;

	[Token(Token = "0x6003D43")]
	[Address(RVA = "0x75BCD0", Offset = "0x75A4D0", Length = "0x64")]
	public GlobalOptionPair()
	{
	}
}
