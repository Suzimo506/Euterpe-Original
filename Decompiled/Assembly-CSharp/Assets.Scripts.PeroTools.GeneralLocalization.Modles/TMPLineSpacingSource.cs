using Cpp2ILInjected;
using TMPro;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x200067D")]
[Attribute(Name = "SourcePathAttribute", RVA = "0x371D0", Offset = "0x365D0")]
public class TMPLineSpacingSource : SourceGeneric<TextMeshProUGUI>
{
	[Token(Token = "0x6003D88")]
	[Address(RVA = "0x762AE0", Offset = "0x7612E0", Length = "0x42")]
	protected override TextMeshProUGUI DefaultSource(Localization localiation)
	{
		return null;
	}

	[Token(Token = "0x6003D89")]
	[Address(RVA = "0x762B30", Offset = "0x761330", Length = "0x38")]
	public TMPLineSpacingSource()
	{
		((SourceGeneric<>)(object)this)._002Ector();
	}
}
