using Assets.Scripts.PeroTools.GeneralLocalization;
using Cpp2ILInjected;
using UnityEngine.UI;

namespace PeroTools.GeneralLocalization.Modles;

[Attribute(Name = "SourcePathAttribute", RVA = "0x36A50", Offset = "0x35E50")]
[Token(Token = "0x2000447")]
public class FontSizeSource : SourceGeneric<Text>
{
	[Token(Token = "0x6003266")]
	[Address(RVA = "0x4F51F0", Offset = "0x4F39F0", Length = "0x42")]
	protected override Text DefaultSource(Localization localiation)
	{
		return null;
	}

	[Address(RVA = "0x4F5240", Offset = "0x4F3A40", Length = "0x38")]
	[Token(Token = "0x6003267")]
	public FontSizeSource()
	{
		((SourceGeneric<>)(object)this)._002Ector();
	}
}
