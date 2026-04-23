using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x200066E")]
public class ImageOption : OptionGeneric<ImageSource, Sprite>
{
	[Address(RVA = "0x75BF70", Offset = "0x75A770", Length = "0x2A")]
	[Token(Token = "0x6003D68")]
	protected override void OnApply(ImageSource source, Localization localization)
	{
	}

	[Token(Token = "0x6003D69")]
	[Address(RVA = "0x75BFA0", Offset = "0x75A7A0", Length = "0x38")]
	public ImageOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
