using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Structs;

[Serializable]
[Token(Token = "0x200058A")]
public struct TalkBaseImg
{
	[Token(Token = "0x40020A7")]
	[FieldOffset(Offset = "0x0")]
	public int index;

	[Token(Token = "0x40020A8")]
	[FieldOffset(Offset = "0x8")]
	public Sprite roleLTSp;

	[Token(Token = "0x40020A9")]
	[FieldOffset(Offset = "0x10")]
	public Sprite roleLBSp;

	[Token(Token = "0x40020AA")]
	[FieldOffset(Offset = "0x18")]
	public Sprite bossRTSp;

	[Token(Token = "0x40020AB")]
	[FieldOffset(Offset = "0x20")]
	public Sprite bossRBSp;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40020AC")]
	public Sprite asideUpSp;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40020AD")]
	public Sprite asideDownSp;

	[Token(Token = "0x17000527")]
	public bool isValid
	{
		[Token(Token = "0x600388D")]
		[Address(RVA = "0x65E840", Offset = "0x65D040", Length = "0x7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600388E")]
	[Address(RVA = "0x65E7F0", Offset = "0x65CFF0", Length = "0x50")]
	public Sprite GetTalkBase(int charIndex, int dirIndex)
	{
		return null;
	}

	[Token(Token = "0x600388F")]
	[Address(RVA = "0x65E7D0", Offset = "0x65CFD0", Length = "0x16")]
	public Sprite GetRoleTalkBase(int dirIndex)
	{
		return null;
	}

	[Token(Token = "0x6003890")]
	[Address(RVA = "0x65E7B0", Offset = "0x65CFB0", Length = "0x16")]
	public Sprite GetBossTalkBase(int dirIndex)
	{
		return null;
	}

	[Address(RVA = "0x65E790", Offset = "0x65CF90", Length = "0x16")]
	[Token(Token = "0x6003891")]
	public Sprite GetAsideTalkBase(int dirIndex)
	{
		return null;
	}
}
