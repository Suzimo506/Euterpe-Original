using System;
using Cpp2ILInjected;

namespace Assets.Scripts.Structs;

[Token(Token = "0x200058D")]
public struct TimeLimitedItemArgs
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40020B4")]
	public string itemType;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40020B5")]
	public int itemIndex;

	[Token(Token = "0x40020B6")]
	[FieldOffset(Offset = "0x10")]
	public DateTime startTime;

	[Token(Token = "0x40020B7")]
	[FieldOffset(Offset = "0x18")]
	public DateTime endTime;

	[Token(Token = "0x40020B8")]
	[FieldOffset(Offset = "0x20")]
	public bool useOnSaleMaxVersion;

	[Token(Token = "0x6003893")]
	[Address(RVA = "0x6605E0", Offset = "0x65EDE0", Length = "0x48")]
	public TimeLimitedItemArgs(string itemType, int itemIndex, DateTime startTime, DateTime endTime, bool useOnSaleMaxVersion = false)
	{
	}
}
