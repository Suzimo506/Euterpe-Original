using Assets.Scripts.PeroTools.GeneralLocalization;
using Cpp2ILInjected;

namespace PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x2000449")]
public class FontSizeOption : OptionGeneric<FontSizeSource, FontSize>
{
	[Token(Token = "0x6003269")]
	[Address(RVA = "0x4F5130", Offset = "0x4F3930", Length = "0x73")]
	protected override void OnApply(FontSizeSource source, Localization localization)
	{
	}

	[Token(Token = "0x600326A")]
	[Address(RVA = "0x4F50E0", Offset = "0x4F38E0", Length = "0x43")]
	protected override FontSize DefaultValue(Localization localization)
	{
		return null;
	}

	[Address(RVA = "0x4F51B0", Offset = "0x4F39B0", Length = "0x38")]
	[Token(Token = "0x600326B")]
	public FontSizeOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
