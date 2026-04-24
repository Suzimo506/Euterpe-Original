using System;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000241")]
public class IRailHttpSessionHelperImpl : RailObject, IRailHttpSessionHelper
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x600285A")]
	internal IRailHttpSessionHelperImpl(IntPtr cPtr)
	{
	}

	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	[Token(Token = "0x600285B")]
	~IRailHttpSessionHelperImpl()
	{
	}

	[Address(RVA = "0xD2C380", Offset = "0xD2AB80", Length = "0xA0")]
	[Token(Token = "0x600285C")]
	public virtual IRailHttpSession CreateHttpSession()
	{
		return null;
	}

	[Token(Token = "0x600285D")]
	[Address(RVA = "0xD2C2D0", Offset = "0xD2AAD0", Length = "0xA7")]
	public virtual IRailHttpResponse CreateHttpResponse(string http_response_data)
	{
		return null;
	}
}
