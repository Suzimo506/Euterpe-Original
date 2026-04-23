using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x2000671")]
[Attribute(Name = "SourcePathAttribute", RVA = "0x36D90", Offset = "0x36190")]
public class RectTramAnchorsSource : SourceGeneric<RectTransform>
{
	[Address(RVA = "0x7618A0", Offset = "0x7600A0", Length = "0x42")]
	[Token(Token = "0x6003D6F")]
	protected override RectTransform DefaultSource(Localization localiation)
	{
		return null;
	}

	[Address(RVA = "0x7618F0", Offset = "0x7600F0", Length = "0x38")]
	[Token(Token = "0x6003D70")]
	public RectTramAnchorsSource()
	{
		((SourceGeneric<>)(object)this)._002Ector();
	}
}
