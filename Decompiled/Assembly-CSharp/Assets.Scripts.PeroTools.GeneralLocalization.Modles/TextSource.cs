using Cpp2ILInjected;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Attribute(Name = "SourcePathAttribute", RVA = "0x37300", Offset = "0x36700")]
[Token(Token = "0x200067F")]
public class TextSource : SourceGeneric<Text>
{
	[Token(Token = "0x6003D8C")]
	[Address(RVA = "0x763710", Offset = "0x761F10", Length = "0x42")]
	protected override Text DefaultSource(Localization localiation)
	{
		return null;
	}

	[Token(Token = "0x6003D8D")]
	[Address(RVA = "0x763760", Offset = "0x761F60", Length = "0x38")]
	public TextSource()
	{
		((SourceGeneric<>)(object)this)._002Ector();
	}
}
