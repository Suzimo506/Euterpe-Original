using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200023F")]
public class IRailHttpResponseImpl : RailObject, IRailHttpResponse, IRailComponent
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x6002842")]
	internal IRailHttpResponseImpl(IntPtr cPtr)
	{
	}

	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	[Token(Token = "0x6002843")]
	~IRailHttpResponseImpl()
	{
	}

	[Token(Token = "0x6002844")]
	[Address(RVA = "0xD2BFB0", Offset = "0xD2A7B0", Length = "0x55")]
	public virtual int GetHttpResponseCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002845")]
	[Address(RVA = "0xD2C0D0", Offset = "0xD2A8D0", Length = "0x12E")]
	public virtual RailResult GetResponseHeaderKeys(List<string> header_keys)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD2C200", Offset = "0xD2AA00", Length = "0x6F")]
	[Token(Token = "0x6002846")]
	public virtual string GetResponseHeaderValue(string header_key)
	{
		return null;
	}

	[Token(Token = "0x6002847")]
	[Address(RVA = "0xD2C070", Offset = "0xD2A870", Length = "0x5F")]
	public virtual string GetResponseBodyData()
	{
		return null;
	}

	[Address(RVA = "0xD2BE90", Offset = "0xD2A690", Length = "0x55")]
	[Token(Token = "0x6002848")]
	public virtual uint GetContentLength()
	{
		return default(uint);
	}

	[Address(RVA = "0xD2BF50", Offset = "0xD2A750", Length = "0x5F")]
	[Token(Token = "0x6002849")]
	public virtual string GetContentType()
	{
		return null;
	}

	[Token(Token = "0x600284A")]
	[Address(RVA = "0xD2BEF0", Offset = "0xD2A6F0", Length = "0x5F")]
	public virtual string GetContentRange()
	{
		return null;
	}

	[Address(RVA = "0xD2BE30", Offset = "0xD2A630", Length = "0x5F")]
	[Token(Token = "0x600284B")]
	public virtual string GetContentLanguage()
	{
		return null;
	}

	[Token(Token = "0x600284C")]
	[Address(RVA = "0xD2BDD0", Offset = "0xD2A5D0", Length = "0x5F")]
	public virtual string GetContentEncoding()
	{
		return null;
	}

	[Address(RVA = "0xD2C010", Offset = "0xD2A810", Length = "0x5F")]
	[Token(Token = "0x600284D")]
	public virtual string GetLastModified()
	{
		return null;
	}

	[Token(Token = "0x600284E")]
	[Address(RVA = "0xD2BD70", Offset = "0xD2A570", Length = "0x55")]
	public virtual ulong GetComponentVersion()
	{
		return default(ulong);
	}

	[Address(RVA = "0xD2C270", Offset = "0xD2AA70", Length = "0x55")]
	[Token(Token = "0x600284F")]
	public virtual void Release()
	{
	}
}
