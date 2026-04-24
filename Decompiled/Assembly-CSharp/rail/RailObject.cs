using System;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000261")]
public class RailObject
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000FCD")]
	protected IntPtr swigCPtr_;

	[Address(RVA = "0x2720C40", Offset = "0x271F440", Length = "0x3B")]
	[Token(Token = "0x60029F6")]
	internal RailObject()
	{
	}

	[Token(Token = "0x60029F7")]
	[Address(RVA = "0x2720C80", Offset = "0x271F480", Length = "0x3B")]
	internal static IntPtr getCPtr(RailObject obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x60029F8")]
	[Address(RVA = "0x14CCFC0", Offset = "0x14CB7C0", Length = "0x53")]
	~RailObject()
	{
	}
}
