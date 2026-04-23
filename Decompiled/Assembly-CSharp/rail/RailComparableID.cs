using System;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200022B")]
public class RailComparableID : IEquatable<RailComparableID>, IComparable<RailComparableID>
{
	[Token(Token = "0x4000FCB")]
	public static readonly RailComparableID Nil;

	[Token(Token = "0x4000FCC")]
	[FieldOffset(Offset = "0x10")]
	public ulong id_;

	[Token(Token = "0x6002725")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public RailComparableID()
	{
	}

	[Token(Token = "0x6002726")]
	[Address(RVA = "0x699950", Offset = "0x698150", Length = "0x26")]
	public RailComparableID(ulong id)
	{
	}

	[Address(RVA = "0x4D3F40", Offset = "0x4D2740", Length = "0x9")]
	[Token(Token = "0x6002727")]
	public bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x6002728")]
	[Address(RVA = "0x6997D0", Offset = "0x697FD0", Length = "0xFD")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Address(RVA = "0x6998D0", Offset = "0x6980D0", Length = "0xB")]
	[Token(Token = "0x6002729")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Address(RVA = "0x699980", Offset = "0x698180", Length = "0xE1")]
	[Token(Token = "0x600272A")]
	public static bool operator ==(RailComparableID x, RailComparableID y)
	{
		return default(bool);
	}

	[Address(RVA = "0x699AD0", Offset = "0x6982D0", Length = "0x11A")]
	[Token(Token = "0x600272B")]
	public static bool operator !=(RailComparableID x, RailComparableID y)
	{
		return default(bool);
	}

	[Token(Token = "0x600272C")]
	[Address(RVA = "0x699A70", Offset = "0x698270", Length = "0x53")]
	public static explicit operator RailComparableID(ulong value)
	{
		return null;
	}

	[Address(RVA = "0x52B3F0", Offset = "0x529BF0", Length = "0x17")]
	[Token(Token = "0x600272D")]
	public static explicit operator ulong(RailComparableID that)
	{
		return default(ulong);
	}

	[Address(RVA = "0x699700", Offset = "0x697F00", Length = "0xC7")]
	[Token(Token = "0x600272E")]
	public bool Equals(RailComparableID other)
	{
		return default(bool);
	}

	[Address(RVA = "0x6996D0", Offset = "0x697ED0", Length = "0x22")]
	[Token(Token = "0x600272F")]
	public int CompareTo(RailComparableID other)
	{
		return default(int);
	}

	[Address(RVA = "0x6998E0", Offset = "0x6980E0", Length = "0xB")]
	[Token(Token = "0x6002730")]
	public override string ToString()
	{
		return null;
	}
}
