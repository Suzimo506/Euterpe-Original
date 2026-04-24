using Cpp2ILInjected;
using TMPro;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Attribute(Name = "SourcePathAttribute", RVA = "0x370F0", Offset = "0x364F0")]
[Token(Token = "0x200067B")]
public class TMPFontSizeSource : SourceGeneric<TextMeshProUGUI>
{
	[Token(Token = "0x6003D84")]
	[Address(RVA = "0x7629E0", Offset = "0x7611E0", Length = "0x42")]
	protected override TextMeshProUGUI DefaultSource(Localization localiation)
	{
		return null;
	}

	[Address(RVA = "0x762A30", Offset = "0x761230", Length = "0x38")]
	[Token(Token = "0x6003D85")]
	public TMPFontSizeSource()
	{
		((SourceGeneric<>)(object)this)._002Ector();
	}
}
