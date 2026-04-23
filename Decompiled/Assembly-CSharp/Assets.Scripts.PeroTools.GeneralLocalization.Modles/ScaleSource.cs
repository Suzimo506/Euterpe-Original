using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x2000674")]
[Attribute(Name = "SourcePathAttribute", RVA = "0x36EC0", Offset = "0x362C0")]
public class ScaleSource : SourceGeneric<Transform>
{
	[Token(Token = "0x6003D75")]
	[Address(RVA = "0x761A50", Offset = "0x760250", Length = "0x42")]
	protected override Transform DefaultSource(Localization localiation)
	{
		return null;
	}

	[Token(Token = "0x6003D76")]
	[Address(RVA = "0x761AA0", Offset = "0x7602A0", Length = "0x38")]
	public ScaleSource()
	{
		((SourceGeneric<>)(object)this)._002Ector();
	}
}
