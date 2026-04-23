using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.GameMain;

[Serializable]
[Token(Token = "0x2000898")]
public class PnlReadyComps
{
	[Token(Token = "0x4002CB3")]
	[FieldOffset(Offset = "0x10")]
	public int index;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002CB4")]
	public GameObject ready;

	[Token(Token = "0x4002CB5")]
	[FieldOffset(Offset = "0x20")]
	public Animator animator;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002CB6")]
	public string animName;

	[Token(Token = "0x4002CB7")]
	[FieldOffset(Offset = "0x30")]
	public string audioName;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6004DE5")]
	public PnlReadyComps()
	{
	}
}
