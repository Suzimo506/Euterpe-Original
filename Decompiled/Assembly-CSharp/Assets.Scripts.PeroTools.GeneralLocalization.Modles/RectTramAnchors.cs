using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Serializable]
[Token(Token = "0x2000672")]
public class RectTramAnchors
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40023C5")]
	public Vector2 min;

	[Token(Token = "0x40023C6")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 max;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003D71")]
	public RectTramAnchors()
	{
	}
}
