using System;
using Cpp2ILInjected;

namespace Assets.Scripts.Structs;

[Serializable]
[Token(Token = "0x200058C")]
public struct ExchangeArgs
{
	[Token(Token = "0x40020B0")]
	public const int loading = 1;

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40020B1")]
	public int code;

	[Token(Token = "0x40020B2")]
	[FieldOffset(Offset = "0x8")]
	public string msg;

	[Token(Token = "0x40020B3")]
	[FieldOffset(Offset = "0x10")]
	public ExchangeItem[] data;
}
