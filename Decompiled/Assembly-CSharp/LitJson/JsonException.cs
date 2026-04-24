using System;
using Cpp2ILInjected;

namespace LitJson;

[Token(Token = "0x20003F5")]
public class JsonException : ApplicationException
{
	[Token(Token = "0x600304B")]
	[Address(RVA = "0x5CBCB0", Offset = "0x5CA4B0", Length = "0x7")]
	public JsonException()
	{
	}

	[Address(RVA = "0x5CBCC0", Offset = "0x5CA4C0", Length = "0x6A")]
	[Token(Token = "0x600304C")]
	internal JsonException(ParserToken token)
	{
	}

	[Address(RVA = "0x5CBD30", Offset = "0x5CA530", Length = "0x7A")]
	[Token(Token = "0x600304D")]
	internal JsonException(ParserToken token, Exception inner_exception)
	{
	}

	[Token(Token = "0x600304E")]
	[Address(RVA = "0x5CBDB0", Offset = "0x5CA5B0", Length = "0x6B")]
	internal JsonException(int c)
	{
	}

	[Address(RVA = "0x5CBE20", Offset = "0x5CA620", Length = "0x7B")]
	[Token(Token = "0x600304F")]
	internal JsonException(int c, Exception inner_exception)
	{
	}

	[Token(Token = "0x6003050")]
	[Address(RVA = "0x5CBCA0", Offset = "0x5CA4A0", Length = "0x8")]
	public JsonException(string message)
	{
	}

	[Token(Token = "0x6003051")]
	[Address(RVA = "0x5CBEA0", Offset = "0x5CA6A0", Length = "0x8")]
	public JsonException(string message, Exception inner_exception)
	{
	}
}
