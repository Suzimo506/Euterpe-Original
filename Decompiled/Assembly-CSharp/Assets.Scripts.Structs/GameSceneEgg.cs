using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Structs;

[Serializable]
[Token(Token = "0x2000573")]
public class GameSceneEgg
{
	[SerializeField]
	[Token(Token = "0x400202C")]
	[FieldOffset(Offset = "0x10")]
	private int m_Index;

	[Token(Token = "0x400202D")]
	[FieldOffset(Offset = "0x14")]
	private bool m_IsToggle;

	[Token(Token = "0x400202E")]
	[FieldOffset(Offset = "0x18")]
	public List<GameObject> originalSceneEgg;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400202F")]
	public List<GameObject> replaceSceneEgg;

	[Token(Token = "0x17000520")]
	public int index
	{
		[Token(Token = "0x6003855")]
		[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000521")]
	public bool isToggle
	{
		[Address(RVA = "0x44C9C0", Offset = "0x44B1C0", Length = "0x5")]
		[Token(Token = "0x6003856")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6003857")]
	[Address(RVA = "0x656A50", Offset = "0x655250", Length = "0x6F")]
	public void Toggle(bool? toggle = null)
	{
	}

	[Token(Token = "0x6003858")]
	[Address(RVA = "0x656860", Offset = "0x655060", Length = "0x1E2")]
	private void Private_Toggle(bool tgl)
	{
	}

	[Token(Token = "0x6003859")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public GameSceneEgg()
	{
	}
}
