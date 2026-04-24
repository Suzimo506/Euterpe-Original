using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x200000C")]
public struct StageTimeEventItem
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400001A")]
	public int actionIndex;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x8")]
	public string soundPath;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x10")]
	public GameObject sceneObject;
}
