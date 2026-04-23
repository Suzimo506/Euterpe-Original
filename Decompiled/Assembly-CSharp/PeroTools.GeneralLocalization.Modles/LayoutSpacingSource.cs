using Assets.Scripts.PeroTools.GeneralLocalization;
using Cpp2ILInjected;
using UnityEngine.UI;

namespace PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x200044D")]
[Attribute(Name = "SourcePathAttribute", RVA = "0x36D60", Offset = "0x36160")]
public class LayoutSpacingSource : SourceGeneric<HorizontalLayoutGroup>
{
	[Token(Token = "0x6003272")]
	[Address(RVA = "0x4F5960", Offset = "0x4F4160", Length = "0x42")]
	protected override HorizontalLayoutGroup DefaultSource(Localization localiation)
	{
		return null;
	}

	[Address(RVA = "0x4F59B0", Offset = "0x4F41B0", Length = "0x38")]
	[Token(Token = "0x6003273")]
	public LayoutSpacingSource()
	{
		((SourceGeneric<>)(object)this)._002Ector();
	}
}
