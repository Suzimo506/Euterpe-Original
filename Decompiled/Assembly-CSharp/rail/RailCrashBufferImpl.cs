using System;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200025F")]
public class RailCrashBufferImpl : RailObject, RailCrashBuffer
{
	[Token(Token = "0x60029EA")]
	[Address(RVA = "0x271F940", Offset = "0x271E140", Length = "0x4C")]
	internal RailCrashBufferImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x60029EB")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~RailCrashBufferImpl()
	{
	}

	[Token(Token = "0x60029EC")]
	[Address(RVA = "0x271F770", Offset = "0x271DF70", Length = "0x5F")]
	public virtual string GetData()
	{
		return null;
	}

	[Token(Token = "0x60029ED")]
	[Address(RVA = "0x271F710", Offset = "0x271DF10", Length = "0x55")]
	public virtual uint GetBufferLength()
	{
		return default(uint);
	}

	[Token(Token = "0x60029EE")]
	[Address(RVA = "0x271F7D0", Offset = "0x271DFD0", Length = "0x55")]
	public virtual uint GetValidLength()
	{
		return default(uint);
	}

	[Token(Token = "0x60029EF")]
	[Address(RVA = "0x271F830", Offset = "0x271E030", Length = "0x8B")]
	public virtual uint SetData(string data, uint length, uint offset)
	{
		return default(uint);
	}

	[Address(RVA = "0x271F8C0", Offset = "0x271E0C0", Length = "0x75")]
	[Token(Token = "0x60029F0")]
	public virtual uint SetData(string data, uint length)
	{
		return default(uint);
	}

	[Token(Token = "0x60029F1")]
	[Address(RVA = "0x271F690", Offset = "0x271DE90", Length = "0x75")]
	public virtual uint AppendData(string data, uint length)
	{
		return default(uint);
	}
}
