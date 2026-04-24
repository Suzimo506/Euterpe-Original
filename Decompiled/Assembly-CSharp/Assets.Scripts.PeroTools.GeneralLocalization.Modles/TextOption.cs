using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x2000680")]
public class TextOption : OptionGeneric<TextSource, string>
{
	[Token(Token = "0x6003D8E")]
	[Address(RVA = "0x763640", Offset = "0x761E40", Length = "0x8E")]
	protected override void OnApply(TextSource source, Localization localization)
	{
	}

	[Token(Token = "0x6003D8F")]
	[Address(RVA = "0x7636D0", Offset = "0x761ED0", Length = "0x38")]
	public TextOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
