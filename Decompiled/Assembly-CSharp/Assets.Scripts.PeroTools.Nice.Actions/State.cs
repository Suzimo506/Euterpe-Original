using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Serializable]
[Token(Token = "0x2000614")]
public class State
{
	[Token(Token = "0x4002245")]
	[FieldOffset(Offset = "0x10")]
	public UnityEngine.Object txtObj;

	[Token(Token = "0x4002246")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 range;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002247")]
	public StateAnim txtAnim;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002248")]
	public StateAnim otherAnim;

	[Token(Token = "0x6003B4C")]
	[Address(RVA = "0x74EAC0", Offset = "0x74D2C0", Length = "0x8C")]
	public State()
	{
	}
}
