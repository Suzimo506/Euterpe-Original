using System;
using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x2000432")]
public class ResultException : Exception
{
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400174C")]
	public readonly Result Result;

	[Address(RVA = "0x21B9E90", Offset = "0x21B8690", Length = "0xB0")]
	[Token(Token = "0x6003156")]
	public ResultException(Result result)
	{
	}
}
