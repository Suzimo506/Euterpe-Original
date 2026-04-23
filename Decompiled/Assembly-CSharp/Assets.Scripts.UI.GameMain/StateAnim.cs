using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.GameMain;

[Serializable]
[Token(Token = "0x2000892")]
public class StateAnim
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002C8F")]
	public Animator animator;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002C90")]
	public string inName;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002C91")]
	public string standbyName;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002C92")]
	public string outName;

	[Token(Token = "0x6004DC7")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public StateAnim()
	{
	}
}
