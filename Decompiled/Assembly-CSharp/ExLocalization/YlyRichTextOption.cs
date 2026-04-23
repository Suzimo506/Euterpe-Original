using Assets.Scripts.PeroTools.GeneralLocalization;
using Cpp2ILInjected;

namespace ExLocalization;

[Token(Token = "0x20004B4")]
public class YlyRichTextOption : OptionGeneric<YlyRichTextSource, string>
{
	[Token(Token = "0x600354B")]
	[Address(RVA = "0x45C3C0", Offset = "0x45ABC0", Length = "0x49")]
	protected override void OnApply(YlyRichTextSource source, Localization localization)
	{
	}

	[Token(Token = "0x600354C")]
	[Address(RVA = "0x45C410", Offset = "0x45AC10", Length = "0x38")]
	public YlyRichTextOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
