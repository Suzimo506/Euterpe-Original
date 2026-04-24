using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000240")]
public class IRailHttpSessionImpl : RailObject, IRailHttpSession, IRailComponent
{
	[Token(Token = "0x6002850")]
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	internal IRailHttpSessionImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6002851")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailHttpSessionImpl()
	{
	}

	[Address(RVA = "0xD2C830", Offset = "0xD2B030", Length = "0x63")]
	[Token(Token = "0x6002852")]
	public virtual RailResult SetRequestMethod(RailHttpSessionMethod method)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD2C560", Offset = "0xD2AD60", Length = "0x124")]
	[Token(Token = "0x6002853")]
	public virtual RailResult SetParameters(List<RailKeyValue> parameters)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002854")]
	[Address(RVA = "0xD2C690", Offset = "0xD2AE90", Length = "0x65")]
	public virtual RailResult SetPostBodyContent(string body_content)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002855")]
	[Address(RVA = "0xD2C8A0", Offset = "0xD2B0A0", Length = "0x63")]
	public virtual RailResult SetRequestTimeOut(uint timeout_secs)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD2C700", Offset = "0xD2AF00", Length = "0x124")]
	[Token(Token = "0x6002856")]
	public virtual RailResult SetRequestHeaders(List<string> headers)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD2C420", Offset = "0xD2AC20", Length = "0x75")]
	[Token(Token = "0x6002857")]
	public virtual RailResult AsyncSendRequest(string url, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002858")]
	[Address(RVA = "0xD2C4A0", Offset = "0xD2ACA0", Length = "0x55")]
	public virtual ulong GetComponentVersion()
	{
		return default(ulong);
	}

	[Token(Token = "0x6002859")]
	[Address(RVA = "0xD2C500", Offset = "0xD2AD00", Length = "0x55")]
	public virtual void Release()
	{
	}
}
