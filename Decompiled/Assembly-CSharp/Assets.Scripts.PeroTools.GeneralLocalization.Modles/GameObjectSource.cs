using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x2000668")]
[Attribute(Name = "SourcePathAttribute", RVA = "0x36820", Offset = "0x35C20")]
public class GameObjectSource : SourceGeneric<GameObject>
{
	[Address(RVA = "0x4D3530", Offset = "0x4D1D30", Length = "0x1F")]
	[Token(Token = "0x6003D5C")]
	protected override GameObject DefaultSource(Localization localiation)
	{
		return null;
	}

	[Address(RVA = "0x75BC90", Offset = "0x75A490", Length = "0x38")]
	[Token(Token = "0x6003D5D")]
	public GameObjectSource()
	{
		((SourceGeneric<>)(object)this)._002Ector();
	}
}
