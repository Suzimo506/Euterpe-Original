using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Serializable]
[Token(Token = "0x200066B")]
public class Property
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40023C3")]
	public Vector2 cellSize;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40023C4")]
	public Vector2 spacing;

	[Token(Token = "0x6003D62")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public Property()
	{
	}
}
