using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x2000685")]
public class TextLineSpacingOption : OptionGeneric<TextLineSpacingSource, float>
{
	[Token(Token = "0x6003D9A")]
	[Address(RVA = "0x763540", Offset = "0x761D40", Length = "0x2B")]
	protected override void OnApply(TextLineSpacingSource source, Localization localization)
	{
	}

	[Token(Token = "0x6003D9B")]
	[Address(RVA = "0x763570", Offset = "0x761D70", Length = "0x38")]
	public TextLineSpacingOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
