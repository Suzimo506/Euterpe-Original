using System;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000242")]
public class IRailIMEHelperImpl : RailObject, IRailIMEHelper
{
	[Token(Token = "0x600285E")]
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	internal IRailIMEHelperImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x600285F")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailIMEHelperImpl()
	{
	}

	[Token(Token = "0x6002860")]
	[Address(RVA = "0xD2C910", Offset = "0xD2B110", Length = "0x12A")]
	public virtual RailResult EnableIMEHelperTextInputWindow(bool enable, RailTextInputImeWindowOption option)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002861")]
	[Address(RVA = "0xD2CA40", Offset = "0xD2B240", Length = "0x124")]
	public virtual RailResult UpdateIMEHelperTextInputWindowPosition(RailWindowPosition position)
	{
		return default(RailResult);
	}
}
