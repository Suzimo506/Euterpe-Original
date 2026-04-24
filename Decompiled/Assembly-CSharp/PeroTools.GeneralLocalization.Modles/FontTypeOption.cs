using Assets.Scripts.PeroTools.GeneralLocalization;
using Cpp2ILInjected;

namespace PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x200044C")]
public class FontTypeOption : OptionGeneric<FontTypeSource, FontType>
{
	[Token(Token = "0x600326F")]
	[Address(RVA = "0x4F52D0", Offset = "0x4F3AD0", Length = "0x33")]
	protected override void OnApply(FontTypeSource source, Localization localization)
	{
	}

	[Token(Token = "0x6003270")]
	[Address(RVA = "0x4F5280", Offset = "0x4F3A80", Length = "0x43")]
	protected override FontType DefaultValue(Localization localization)
	{
		return null;
	}

	[Token(Token = "0x6003271")]
	[Address(RVA = "0x4F5310", Offset = "0x4F3B10", Length = "0x38")]
	public FontTypeOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
