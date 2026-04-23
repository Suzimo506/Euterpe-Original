using Cpp2ILInjected;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Attribute(Name = "SourcePathAttribute", RVA = "0x377D0", Offset = "0x36BD0")]
[Token(Token = "0x2000684")]
public class TextLineSpacingSource : SourceGeneric<Text>
{
	[Token(Token = "0x6003D98")]
	[Address(RVA = "0x7635B0", Offset = "0x761DB0", Length = "0x42")]
	protected override Text DefaultSource(Localization localiation)
	{
		return null;
	}

	[Token(Token = "0x6003D99")]
	[Address(RVA = "0x763600", Offset = "0x761E00", Length = "0x38")]
	public TextLineSpacingSource()
	{
		((SourceGeneric<>)(object)this)._002Ector();
	}
}
