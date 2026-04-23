using Assets.Scripts.PeroTools.GeneralLocalization;
using Cpp2ILInjected;
using UnityEngine;

namespace ExLocalization;

[Token(Token = "0x20004B2")]
public class YlyRichTextFontOption : OptionGeneric<YlyRichTextFontSource, Font>
{
	[Token(Token = "0x6003547")]
	[Address(RVA = "0x45C2C0", Offset = "0x45AAC0", Length = "0x2A")]
	protected override void OnApply(YlyRichTextFontSource source, Localization localization)
	{
	}

	[Token(Token = "0x6003548")]
	[Address(RVA = "0x45C2F0", Offset = "0x45AAF0", Length = "0x38")]
	public YlyRichTextFontOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
