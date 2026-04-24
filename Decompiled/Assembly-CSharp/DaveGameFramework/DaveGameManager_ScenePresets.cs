using System;
using Cpp2ILInjected;
using UnityEngine;

namespace DaveGameFramework;

[Serializable]
[Token(Token = "0x20004B8")]
public class DaveGameManager_ScenePresets
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40019C2")]
	public GameObject notePrefab;

	[Token(Token = "0x40019C3")]
	[FieldOffset(Offset = "0x18")]
	public Transform activeObjTrans;

	[Token(Token = "0x40019C4")]
	[FieldOffset(Offset = "0x20")]
	public Transform inActiveObjTrans;

	[Token(Token = "0x40019C5")]
	[FieldOffset(Offset = "0x28")]
	public Transform inActiveNoteTrans;

	[Token(Token = "0x600354D")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public DaveGameManager_ScenePresets()
	{
	}
}
