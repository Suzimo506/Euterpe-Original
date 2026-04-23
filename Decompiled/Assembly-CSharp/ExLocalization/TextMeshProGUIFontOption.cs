using Assets.Scripts.PeroTools.GeneralLocalization;
using Cpp2ILInjected;
using TMPro;

namespace ExLocalization;

[Token(Token = "0x20004B0")]
public class TextMeshProGUIFontOption : OptionGeneric<TextMeshProGUIFontSource, TMP_FontAsset>
{
	[Address(RVA = "0x45AB80", Offset = "0x459380", Length = "0x2A")]
	[Token(Token = "0x6003543")]
	protected override void OnApply(TextMeshProGUIFontSource source, Localization localization)
	{
	}

	[Token(Token = "0x6003544")]
	[Address(RVA = "0x45ABB0", Offset = "0x4593B0", Length = "0x38")]
	public TextMeshProGUIFontOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
