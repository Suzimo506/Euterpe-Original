using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000017")]
public struct SkeletonMountData
{
	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x0")]
	public int actionId;

	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x8")]
	public GameObject instance;

	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x10")]
	public int moduleId;
}
