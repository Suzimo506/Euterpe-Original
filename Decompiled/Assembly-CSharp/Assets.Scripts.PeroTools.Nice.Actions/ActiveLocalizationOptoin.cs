using Assets.Scripts.PeroTools.GeneralLocalization;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x200060F")]
public class ActiveLocalizationOptoin : Action
{
	[Token(Token = "0x4002234")]
	[FieldOffset(Offset = "0x10")]
	public OptionEntry optionEntry;

	[Token(Token = "0x4002235")]
	[FieldOffset(Offset = "0x18")]
	public SchemeEntry schemeEntry;

	[Token(Token = "0x6003B39")]
	[Address(RVA = "0x73A1F0", Offset = "0x7389F0", Length = "0x7E")]
	public override void Execute()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003B3A")]
	public ActiveLocalizationOptoin()
	{
	}
}
