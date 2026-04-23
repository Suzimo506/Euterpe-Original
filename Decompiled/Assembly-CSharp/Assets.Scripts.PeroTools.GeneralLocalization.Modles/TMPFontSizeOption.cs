using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x200067C")]
public class TMPFontSizeOption : OptionGeneric<TMPFontSizeSource, int>
{
	[Address(RVA = "0x762970", Offset = "0x761170", Length = "0x2E")]
	[Token(Token = "0x6003D86")]
	protected override void OnApply(TMPFontSizeSource source, Localization localization)
	{
	}

	[Token(Token = "0x6003D87")]
	[Address(RVA = "0x7629A0", Offset = "0x7611A0", Length = "0x38")]
	public TMPFontSizeOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
