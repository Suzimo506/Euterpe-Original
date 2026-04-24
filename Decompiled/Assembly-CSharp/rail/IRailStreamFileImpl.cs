using System;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000255")]
public class IRailStreamFileImpl : RailObject, IRailStreamFile, IRailComponent
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x600296A")]
	internal IRailStreamFileImpl(IntPtr cPtr)
	{
	}

	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	[Token(Token = "0x600296B")]
	~IRailStreamFileImpl()
	{
	}

	[Token(Token = "0x600296C")]
	[Address(RVA = "0x375500", Offset = "0x373D00", Length = "0xBE")]
	public virtual string GetFilename()
	{
		return null;
	}

	[Address(RVA = "0x375110", Offset = "0x373910", Length = "0xFB")]
	[Token(Token = "0x600296D")]
	public virtual RailResult AsyncRead(int offset, uint bytes_to_read, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x375210", Offset = "0x373A10", Length = "0x110")]
	[Token(Token = "0x600296E")]
	public virtual RailResult AsyncWrite(byte[] buff, uint bytes_to_write, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x600296F")]
	[Address(RVA = "0x3755C0", Offset = "0x373DC0", Length = "0xB5")]
	public virtual ulong GetSize()
	{
		return default(ulong);
	}

	[Token(Token = "0x6002970")]
	[Address(RVA = "0x3753E0", Offset = "0x373BE0", Length = "0xB5")]
	public virtual RailResult Close()
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002971")]
	[Address(RVA = "0x375320", Offset = "0x373B20", Length = "0xB5")]
	public virtual void Cancel()
	{
	}

	[Address(RVA = "0x3754A0", Offset = "0x373CA0", Length = "0x55")]
	[Token(Token = "0x6002972")]
	public virtual ulong GetComponentVersion()
	{
		return default(ulong);
	}

	[Token(Token = "0x6002973")]
	[Address(RVA = "0x375680", Offset = "0x373E80", Length = "0x55")]
	public virtual void Release()
	{
	}
}
