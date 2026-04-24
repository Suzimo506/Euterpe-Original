using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Serializable]
[Token(Token = "0x2000615")]
public class StateAnim
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002249")]
	public Animator animator;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400224A")]
	public bool isActive;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400224B")]
	public string inName;

	[Token(Token = "0x400224C")]
	[FieldOffset(Offset = "0x28")]
	public string standbyName;

	[Token(Token = "0x400224D")]
	[FieldOffset(Offset = "0x30")]
	public string outName;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003B4D")]
	public StateAnim()
	{
	}
}
