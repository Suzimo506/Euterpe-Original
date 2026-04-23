using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.GameMain;

[Serializable]
[Token(Token = "0x200089A")]
public class VictoryComps
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002CBE")]
	public int index;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002CBF")]
	public GameObject fullCombo;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002CC0")]
	public string fullComboClip;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002CC1")]
	public GameObject victory;

	[Token(Token = "0x4002CC2")]
	[FieldOffset(Offset = "0x30")]
	public string victoryClip;

	[Token(Token = "0x6004DF0")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public VictoryComps()
	{
	}
}
