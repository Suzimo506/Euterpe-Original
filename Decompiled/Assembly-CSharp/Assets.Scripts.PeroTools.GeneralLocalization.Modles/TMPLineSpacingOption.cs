using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x200067E")]
public class TMPLineSpacingOption : OptionGeneric<TMPLineSpacingSource, float>
{
	[Token(Token = "0x6003D8A")]
	[Address(RVA = "0x762A70", Offset = "0x761270", Length = "0x2B")]
	protected override void OnApply(TMPLineSpacingSource source, Localization localization)
	{
	}

	[Address(RVA = "0x762AA0", Offset = "0x7612A0", Length = "0x38")]
	[Token(Token = "0x6003D8B")]
	public TMPLineSpacingOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
