using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x200000D")]
public struct StageActionEvent
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400001D")]
	public int nodeIndex;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x8")]
	public GameObject sceneObject;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x10")]
	public int bornActionIndex;

	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000020")]
	public int hittedActionIndex;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000021")]
	public int missActionIndex;
}
