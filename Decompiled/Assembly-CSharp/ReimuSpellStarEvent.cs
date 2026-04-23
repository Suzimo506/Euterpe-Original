using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000BA")]
public class ReimuSpellStarEvent : MonoBehaviour
{
	[Token(Token = "0x40004D5")]
	[FieldOffset(Offset = "0x18")]
	public List<GameObject> spellImgs;

	[Token(Token = "0x6000571")]
	[Address(RVA = "0x56BEE0", Offset = "0x56A6E0", Length = "0x20C")]
	private void Awake()
	{
	}

	[Address(RVA = "0x56C0F0", Offset = "0x56A8F0", Length = "0x18C")]
	[Token(Token = "0x6000572")]
	private void OnFeverCountChanged()
	{
	}

	[Token(Token = "0x6000573")]
	[Address(RVA = "0x56C280", Offset = "0x56AA80", Length = "0x69")]
	public ReimuSpellStarEvent()
	{
	}
}
