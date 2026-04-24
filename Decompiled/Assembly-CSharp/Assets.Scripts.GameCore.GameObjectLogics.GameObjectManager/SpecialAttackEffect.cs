using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.GameCore.GameObjectLogics.GameObjectManager;

[Serializable]
[Token(Token = "0x2000761")]
internal class SpecialAttackEffect
{
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3E0", Offset = "0x9B7E0")]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400271C")]
	public int spiChar;

	[Token(Token = "0x400271D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject replaceSpiEffect;

	[Token(Token = "0x600455F")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public SpecialAttackEffect()
	{
	}
}
