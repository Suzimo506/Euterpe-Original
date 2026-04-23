using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x2000664")]
[Attribute(Name = "SourcePathAttribute", RVA = "0x365E0", Offset = "0x359E0")]
public class ChildrenSource : SourceGeneric<Transform>
{
	[Address(RVA = "0x43FEC0", Offset = "0x43E6C0", Length = "0x1F")]
	[Token(Token = "0x6003D55")]
	protected override Transform DefaultSource(Localization localiation)
	{
		return null;
	}

	[Token(Token = "0x6003D56")]
	[Address(RVA = "0x755150", Offset = "0x753950", Length = "0x38")]
	public ChildrenSource()
	{
		((SourceGeneric<>)(object)this)._002Ector();
	}
}
