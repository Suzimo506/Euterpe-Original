using System;
using Cpp2ILInjected;

[Token(Token = "0x2000105")]
[Flags]
public enum PackageState
{
	[Token(Token = "0x4000670")]
	Purchased = 1,
	[Token(Token = "0x4000671")]
	UnPurchased = 2,
	[Token(Token = "0x4000672")]
	DisCount = 4,
	[Token(Token = "0x4000673")]
	New = 8,
	[Token(Token = "0x4000674")]
	CannotPurchase = 0x10
}
