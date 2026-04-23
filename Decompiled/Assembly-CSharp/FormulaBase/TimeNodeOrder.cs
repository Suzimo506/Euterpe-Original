using System;
using Cpp2ILInjected;
using GameLogic;

namespace FormulaBase;

[Token(Token = "0x2000462")]
public class TimeNodeOrder : IComparable<TimeNodeOrder>
{
	[Token(Token = "0x2000B2B")]
	public enum MusicDataType
	{
		[Token(Token = "0x4003980")]
		Pressing,
		[Token(Token = "0x4003981")]
		Double,
		[Token(Token = "0x4003982")]
		Mul,
		[Token(Token = "0x4003983")]
		Normal
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40017E6")]
	public short idx;

	[Token(Token = "0x40017E7")]
	[FieldOffset(Offset = "0x12")]
	public byte result;

	[FieldOffset(Offset = "0x13")]
	[Token(Token = "0x40017E8")]
	public bool enableJump;

	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40017E9")]
	public bool isPerfectNode;

	[FieldOffset(Offset = "0x15")]
	[Token(Token = "0x40017EA")]
	public bool isLongPressStart;

	[FieldOffset(Offset = "0x16")]
	[Token(Token = "0x40017EB")]
	public bool isLongPressEnd;

	[Token(Token = "0x40017EC")]
	[FieldOffset(Offset = "0x17")]
	public bool isLongPressing;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40017ED")]
	public bool isMulStart;

	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x40017EE")]
	public bool isMuling;

	[Token(Token = "0x40017EF")]
	[FieldOffset(Offset = "0x1A")]
	public bool isAir;

	[Token(Token = "0x40017F0")]
	[FieldOffset(Offset = "0x1B")]
	public bool isFucked;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40017F1")]
	public bool isLast;

	[FieldOffset(Offset = "0x1D")]
	[Token(Token = "0x40017F2")]
	public bool isFirst;

	[Token(Token = "0x40017F3")]
	[FieldOffset(Offset = "0x1E")]
	public bool isRight;

	[Token(Token = "0x40017F4")]
	[FieldOffset(Offset = "0x20")]
	public MusicData md;

	[Token(Token = "0x1700048A")]
	public bool isLongPressType
	{
		[Address(RVA = "0x84B700", Offset = "0x849F00", Length = "0x14")]
		[Token(Token = "0x60032DF")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700048B")]
	public bool isMulType
	{
		[Address(RVA = "0x84B720", Offset = "0x849F20", Length = "0xD")]
		[Token(Token = "0x60032E0")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x84B2C0", Offset = "0x849AC0", Length = "0x30F")]
	[Token(Token = "0x60032DE")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60032E1")]
	[Address(RVA = "0x84A860", Offset = "0x849060", Length = "0x169")]
	public int CompareTo(TimeNodeOrder other)
	{
		return default(int);
	}

	[Address(RVA = "0x84A9D0", Offset = "0x8491D0", Length = "0x6C4")]
	[Token(Token = "0x60032E2")]
	public static void CopyTimeNodeOrder(TimeNodeOrder tno, MusicData md, MusicDataType type, int curValue, int maxRange, bool isLeft)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60032E3")]
	public TimeNodeOrder()
	{
	}

	[Token(Token = "0x60032E4")]
	[Address(RVA = "0x84B5D0", Offset = "0x849DD0", Length = "0x123")]
	public TimeNodeOrder(TimeNodeOrder tno)
	{
	}

	[Token(Token = "0x60032E5")]
	[Address(RVA = "0x84B0A0", Offset = "0x8498A0", Length = "0x21A")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}
}
