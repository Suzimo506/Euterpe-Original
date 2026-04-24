using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Attribute(Name = "SourcePathAttribute", RVA = "0x36BF0", Offset = "0x35FF0")]
[Token(Token = "0x200066F")]
public class PositionSource : SourceGeneric<Transform>
{
	[Address(RVA = "0x761700", Offset = "0x75FF00", Length = "0x42")]
	[Token(Token = "0x6003D6A")]
	protected override Transform DefaultSource(Localization localiation)
	{
		return null;
	}

	[Token(Token = "0x6003D6B")]
	[Address(RVA = "0x761750", Offset = "0x75FF50", Length = "0x38")]
	public PositionSource()
	{
		((SourceGeneric<>)(object)this)._002Ector();
	}
}
