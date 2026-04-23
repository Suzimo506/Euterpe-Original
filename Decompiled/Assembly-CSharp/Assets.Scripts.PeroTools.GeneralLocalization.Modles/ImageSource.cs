using Cpp2ILInjected;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x200066D")]
[Attribute(Name = "SourcePathAttribute", RVA = "0x36A80", Offset = "0x35E80")]
public class ImageSource : SourceGeneric<Image>
{
	[Address(RVA = "0x75BFE0", Offset = "0x75A7E0", Length = "0x42")]
	[Token(Token = "0x6003D66")]
	protected override Image DefaultSource(Localization localiation)
	{
		return null;
	}

	[Address(RVA = "0x75C030", Offset = "0x75A830", Length = "0x38")]
	[Token(Token = "0x6003D67")]
	public ImageSource()
	{
		((SourceGeneric<>)(object)this)._002Ector();
	}
}
