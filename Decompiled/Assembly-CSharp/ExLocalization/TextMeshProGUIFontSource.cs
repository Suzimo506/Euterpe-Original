using Assets.Scripts.PeroTools.GeneralLocalization;
using Cpp2ILInjected;
using TMPro;

namespace ExLocalization;

[Attribute(Name = "SourcePathAttribute", RVA = "0x4F870", Offset = "0x4EC70")]
[Token(Token = "0x20004AF")]
public class TextMeshProGUIFontSource : SourceGeneric<TextMeshProUGUI>
{
	[Address(RVA = "0x45ABF0", Offset = "0x4593F0", Length = "0x42")]
	[Token(Token = "0x6003541")]
	protected override TextMeshProUGUI DefaultSource(Localization localiation)
	{
		return null;
	}

	[Token(Token = "0x6003542")]
	[Address(RVA = "0x45AC40", Offset = "0x459440", Length = "0x38")]
	public TextMeshProGUIFontSource()
	{
		((SourceGeneric<>)(object)this)._002Ector();
	}
}
