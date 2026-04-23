using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.Bulletin;

[Serializable]
[Token(Token = "0x2000951")]
public class PnlStageBulletinProperty
{
	[Token(Token = "0x40032C8")]
	[FieldOffset(Offset = "0x10")]
	public YlyRichText textContent;

	[Token(Token = "0x40032C9")]
	[FieldOffset(Offset = "0x18")]
	public Image contentImage;

	[Token(Token = "0x40032CA")]
	[FieldOffset(Offset = "0x20")]
	public GameObject toggleBulletin;

	[Token(Token = "0x40032CB")]
	[FieldOffset(Offset = "0x28")]
	public Color originColor;

	[Token(Token = "0x40032CC")]
	[FieldOffset(Offset = "0x38")]
	public Color selectColor;

	[Token(Token = "0x60054A2")]
	[Address(RVA = "0x6CFFD0", Offset = "0x6CE7D0", Length = "0xAA")]
	public PnlStageBulletinProperty()
	{
	}
}
