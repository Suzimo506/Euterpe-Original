using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels;

[Serializable]
[Token(Token = "0x20008CE")]
public class SceneSpriteInfo
{
	[Token(Token = "0x4002DE9")]
	[FieldOffset(Offset = "0x10")]
	public Sprite BGSprite;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002DEA")]
	public Sprite NoteSprite;

	[Token(Token = "0x4002DEB")]
	[FieldOffset(Offset = "0x20")]
	public Sprite BGSprite_Hexie;

	[NonSerialized]
	[Token(Token = "0x4002DEC")]
	[FieldOffset(Offset = "0x28")]
	public float brightness;

	[Token(Token = "0x4002DED")]
	[FieldOffset(Offset = "0x2C")]
	public bool hide;

	[Token(Token = "0x6004F58")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public SceneSpriteInfo()
	{
	}
}
