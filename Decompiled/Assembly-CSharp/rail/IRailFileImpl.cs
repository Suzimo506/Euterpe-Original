using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000235")]
public class IRailFileImpl : RailObject, IRailFile, IRailComponent
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x60027AA")]
	internal IRailFileImpl(IntPtr cPtr)
	{
	}

	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	[Token(Token = "0x60027AB")]
	~IRailFileImpl()
	{
	}

	[Address(RVA = "0xD257A0", Offset = "0xD23FA0", Length = "0x5F")]
	[Token(Token = "0x60027AC")]
	public virtual string GetFilename()
	{
		return null;
	}

	[Token(Token = "0x60027AD")]
	[Address(RVA = "0xD25860", Offset = "0xD24060", Length = "0x8B")]
	public virtual uint Read(byte[] buff, uint bytes_to_read, out RailResult result)
	{
		System.Runtime.CompilerServices.Unsafe.As<RailResult, @null>(ref result) = null;
		return default(uint);
	}

	[Address(RVA = "0xD258F0", Offset = "0xD240F0", Length = "0x75")]
	[Token(Token = "0x60027AE")]
	public virtual uint Read(byte[] buff, uint bytes_to_read)
	{
		return default(uint);
	}

	[Address(RVA = "0xD25A50", Offset = "0xD24250", Length = "0x8B")]
	[Token(Token = "0x60027AF")]
	public virtual uint Write(byte[] buff, uint bytes_to_write, out RailResult result)
	{
		System.Runtime.CompilerServices.Unsafe.As<RailResult, @null>(ref result) = null;
		return default(uint);
	}

	[Address(RVA = "0xD259D0", Offset = "0xD241D0", Length = "0x75")]
	[Token(Token = "0x60027B0")]
	public virtual uint Write(byte[] buff, uint bytes_to_write)
	{
		return default(uint);
	}

	[Token(Token = "0x60027B1")]
	[Address(RVA = "0xD255D0", Offset = "0xD23DD0", Length = "0x73")]
	public virtual RailResult AsyncRead(uint bytes_to_read, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60027B2")]
	[Address(RVA = "0xD25650", Offset = "0xD23E50", Length = "0x8B")]
	public virtual RailResult AsyncWrite(byte[] buffer, uint bytes_to_write, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60027B3")]
	[Address(RVA = "0xD25800", Offset = "0xD24000", Length = "0x55")]
	public virtual uint GetSize()
	{
		return default(uint);
	}

	[Address(RVA = "0xD256E0", Offset = "0xD23EE0", Length = "0x55")]
	[Token(Token = "0x60027B4")]
	public virtual void Close()
	{
	}

	[Token(Token = "0x60027B5")]
	[Address(RVA = "0xD25740", Offset = "0xD23F40", Length = "0x55")]
	public virtual ulong GetComponentVersion()
	{
		return default(ulong);
	}

	[Token(Token = "0x60027B6")]
	[Address(RVA = "0xD25970", Offset = "0xD24170", Length = "0x55")]
	public virtual void Release()
	{
	}
}
