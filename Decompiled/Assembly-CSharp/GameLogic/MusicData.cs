using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace GameLogic;

[Token(Token = "0x20004AC")]
public struct MusicData
{
	[Token(Token = "0x4001970")]
	[FieldOffset(Offset = "0x0")]
	public short objId;

	[Token(Token = "0x4001971")]
	[FieldOffset(Offset = "0x4")]
	public decimal tick;

	[Token(Token = "0x4001972")]
	[FieldOffset(Offset = "0x18")]
	public MusicConfigData configData;

	[NonSerialized]
	[Token(Token = "0x4001973")]
	[FieldOffset(Offset = "0x50")]
	public NoteConfigData noteData;

	[Token(Token = "0x4001974")]
	[FieldOffset(Offset = "0x110")]
	public bool isLongPressing;

	[Token(Token = "0x4001975")]
	[FieldOffset(Offset = "0x114")]
	public int doubleIdx;

	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4001976")]
	public List<int> sameTickNoteIdx;

	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4001977")]
	public bool isDouble;

	[FieldOffset(Offset = "0x121")]
	[Token(Token = "0x4001978")]
	public bool isLongPressEnd;

	[Token(Token = "0x4001979")]
	[FieldOffset(Offset = "0x124")]
	public decimal longPressPTick;

	[FieldOffset(Offset = "0x134")]
	[Token(Token = "0x400197A")]
	public int endIndex;

	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x400197B")]
	public decimal dt;

	[Token(Token = "0x400197C")]
	[FieldOffset(Offset = "0x148")]
	public int longPressNum;

	[FieldOffset(Offset = "0x14C")]
	[Token(Token = "0x400197D")]
	public decimal showTick;

	[FieldOffset(Offset = "0x15C")]
	[Token(Token = "0x400197E")]
	private int m_BattleScore;

	[Token(Token = "0x170004D4")]
	public bool IsDouble
	{
		[Token(Token = "0x600352F")]
		[Address(RVA = "0x5D4930", Offset = "0x5D3130", Length = "0x17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004D5")]
	public int BattleScore
	{
		[Address(RVA = "0x5D48E0", Offset = "0x5D30E0", Length = "0x11")]
		[Token(Token = "0x6003530")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170004D6")]
	public bool isLongPressType
	{
		[Token(Token = "0x6003535")]
		[Address(RVA = "0x5D4A30", Offset = "0x5D3230", Length = "0x31")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004D7")]
	public bool isAir
	{
		[Address(RVA = "0x5D4950", Offset = "0x5D3150", Length = "0xB")]
		[Token(Token = "0x6003536")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004D8")]
	public bool isMul
	{
		[Token(Token = "0x6003537")]
		[Address(RVA = "0x5D4A70", Offset = "0x5D3270", Length = "0xA1")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004D9")]
	public bool isLongPressStart
	{
		[Address(RVA = "0x5D4980", Offset = "0x5D3180", Length = "0xA1")]
		[Token(Token = "0x6003538")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004DA")]
	public int longPressCount
	{
		[Address(RVA = "0x5D4B20", Offset = "0x5D3320", Length = "0xF8")]
		[Token(Token = "0x6003539")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170004DB")]
	public bool isBossNote
	{
		[Address(RVA = "0x5D4960", Offset = "0x5D3160", Length = "0x19")]
		[Token(Token = "0x600353A")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004DC")]
	public bool IsBossNearAttack
	{
		[Token(Token = "0x600353B")]
		[Address(RVA = "0x5D4900", Offset = "0x5D3100", Length = "0x30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004DD")]
	public decimal missTick
	{
		[Token(Token = "0x600353C")]
		[Address(RVA = "0x5D4C20", Offset = "0x5D3420", Length = "0x174")]
		get
		{
			return default(decimal);
		}
	}

	[Token(Token = "0x6003531")]
	[Address(RVA = "0x5D4470", Offset = "0x5D2C70", Length = "0x7E")]
	public void ChangeNoteScore(float multipleRate)
	{
	}

	[Address(RVA = "0x5D45E0", Offset = "0x5D2DE0", Length = "0xEF")]
	[Token(Token = "0x6003532")]
	public int GetMulHitLowThreshold()
	{
		return default(int);
	}

	[Token(Token = "0x6003533")]
	[Address(RVA = "0x5D46D0", Offset = "0x5D2ED0", Length = "0xEF")]
	public int GetMulHitMidThreshold()
	{
		return default(int);
	}

	[Token(Token = "0x6003534")]
	[Address(RVA = "0x5D44F0", Offset = "0x5D2CF0", Length = "0xEF")]
	public int GetMulHitHighThreshold()
	{
		return default(int);
	}

	[Token(Token = "0x600353D")]
	[Address(RVA = "0x5D47C0", Offset = "0x5D2FC0", Length = "0x112")]
	public override string ToString()
	{
		return null;
	}
}
