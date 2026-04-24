using Assets.Scripts.PeroTools.GeneralLocalization;
using Cpp2ILInjected;
using UnityEngine;

namespace PeroTools.GeneralLocalization.Modles;

[Attribute(Name = "SourcePathAttribute", RVA = "0x36E40", Offset = "0x36240")]
[Token(Token = "0x2000450")]
public class RectTramPosSource : SourceGeneric<RectTransform>
{
	[Address(RVA = "0x5047B0", Offset = "0x502FB0", Length = "0x42")]
	[Token(Token = "0x6003278")]
	protected override RectTransform DefaultSource(Localization localiation)
	{
		return null;
	}

	[Address(RVA = "0x504800", Offset = "0x503000", Length = "0x38")]
	[Token(Token = "0x6003279")]
	public RectTramPosSource()
	{
		((SourceGeneric<>)(object)this)._002Ector();
	}
}
