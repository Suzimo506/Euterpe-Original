using Cpp2ILInjected;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x200066A")]
[Attribute(Name = "SourcePathAttribute", RVA = "0x369E0", Offset = "0x35DE0")]
public class GridLayoutGroupSource : SourceGeneric<GridLayoutGroup>
{
	[Token(Token = "0x6003D60")]
	[Address(RVA = "0x75BEE0", Offset = "0x75A6E0", Length = "0x42")]
	protected override GridLayoutGroup DefaultSource(Localization localiation)
	{
		return null;
	}

	[Token(Token = "0x6003D61")]
	[Address(RVA = "0x75BF30", Offset = "0x75A730", Length = "0x38")]
	public GridLayoutGroupSource()
	{
		((SourceGeneric<>)(object)this)._002Ector();
	}
}
