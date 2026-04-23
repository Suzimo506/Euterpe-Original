using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.StageBackground.DaveMainShow;

[Serializable]
[Token(Token = "0x200083F")]
public class DaveFishTypeDefines
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002B1A")]
	public Sprite fishShallows;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002B1B")]
	public Sprite fishMediumDepth;

	[Token(Token = "0x4002B1C")]
	[FieldOffset(Offset = "0x20")]
	public Sprite fishDepths;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002B1D")]
	public Sprite fishLocked;

	[Token(Token = "0x6004BE3")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public DaveFishTypeDefines()
	{
	}
}
