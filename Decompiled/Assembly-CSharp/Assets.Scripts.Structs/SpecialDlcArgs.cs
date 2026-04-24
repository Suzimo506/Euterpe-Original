using System;
using Cpp2ILInjected;

namespace Assets.Scripts.Structs;

[Token(Token = "0x200057B")]
internal struct SpecialDlcArgs
{
	[Token(Token = "0x4002050")]
	[FieldOffset(Offset = "0x0")]
	internal string productId;

	[Token(Token = "0x4002051")]
	[FieldOffset(Offset = "0x8")]
	internal int albumJsonUid;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002052")]
	internal DateTime startTime;

	[Token(Token = "0x4002053")]
	[FieldOffset(Offset = "0x18")]
	internal DateTime endTime;

	[Token(Token = "0x4002054")]
	[FieldOffset(Offset = "0x20")]
	internal CheckRoleItemParams checkRoleItemParams;

	[Address(RVA = "0x65DC10", Offset = "0x65C410", Length = "0x67")]
	[Token(Token = "0x600386E")]
	internal SpecialDlcArgs(string product, int jsonIndex, DateTime sTime, DateTime eTime, CheckRoleItemParams itemParams)
	{
	}
}
