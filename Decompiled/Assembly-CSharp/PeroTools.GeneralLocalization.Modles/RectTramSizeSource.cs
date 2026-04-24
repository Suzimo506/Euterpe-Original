using Assets.Scripts.PeroTools.GeneralLocalization;
using Cpp2ILInjected;
using UnityEngine;

namespace PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x2000453")]
[Attribute(Name = "SourcePathAttribute", RVA = "0x36F20", Offset = "0x36320")]
public class RectTramSizeSource : SourceGeneric<RectTransform>
{
	[Address(RVA = "0x504930", Offset = "0x503130", Length = "0x42")]
	[Token(Token = "0x600327E")]
	protected override RectTransform DefaultSource(Localization localiation)
	{
		return null;
	}

	[Address(RVA = "0x504980", Offset = "0x503180", Length = "0x38")]
	[Token(Token = "0x600327F")]
	public RectTramSizeSource()
	{
		((SourceGeneric<>)(object)this)._002Ector();
	}
}
