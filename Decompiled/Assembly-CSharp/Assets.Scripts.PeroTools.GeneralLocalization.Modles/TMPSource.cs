using Cpp2ILInjected;
using TMPro;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Attribute(Name = "SourcePathAttribute", RVA = "0x37090", Offset = "0x36490")]
[Token(Token = "0x2000678")]
public class TMPSource : SourceGeneric<TextMeshProUGUI>
{
	[Token(Token = "0x6003D7E")]
	[Address(RVA = "0x762D20", Offset = "0x761520", Length = "0x42")]
	protected override TextMeshProUGUI DefaultSource(Localization localiation)
	{
		return null;
	}

	[Address(RVA = "0x762D70", Offset = "0x761570", Length = "0x38")]
	[Token(Token = "0x6003D7F")]
	public TMPSource()
	{
		((SourceGeneric<>)(object)this)._002Ector();
	}
}
