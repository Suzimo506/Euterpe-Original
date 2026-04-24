using System.Collections.Generic;
using Cpp2ILInjected;

namespace FormulaBase;

[Token(Token = "0x2000461")]
public class TnoDefaultComparable : IComparer<TimeNodeOrder>
{
	[Token(Token = "0x40017E5")]
	[FieldOffset(Offset = "0x10")]
	public bool easySort;

	[Address(RVA = "0x84B730", Offset = "0x849F30", Length = "0x114")]
	[Token(Token = "0x60032DB")]
	private int CompareByTick(TimeNodeOrder l, TimeNodeOrder r)
	{
		return default(int);
	}

	[Address(RVA = "0x84B850", Offset = "0x84A050", Length = "0x338")]
	[Token(Token = "0x60032DC")]
	public int Compare(TimeNodeOrder l, TimeNodeOrder r)
	{
		return default(int);
	}

	[Token(Token = "0x60032DD")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public TnoDefaultComparable()
	{
	}
}
