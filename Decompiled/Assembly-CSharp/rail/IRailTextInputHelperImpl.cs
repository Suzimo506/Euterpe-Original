using System;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000257")]
public class IRailTextInputHelperImpl : RailObject, IRailTextInputHelper
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x6002978")]
	internal IRailTextInputHelperImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6002979")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailTextInputHelperImpl()
	{
	}

	[Address(RVA = "0x375B10", Offset = "0x374310", Length = "0x23D")]
	[Token(Token = "0x600297A")]
	public virtual RailResult ShowTextInputWindow(RailTextInputWindowOption options)
	{
		return default(RailResult);
	}

	[Token(Token = "0x600297B")]
	[Address(RVA = "0x375870", Offset = "0x374070", Length = "0x1D6")]
	public virtual void GetTextInputContent(out string content)
	{
		content = null;
	}

	[Address(RVA = "0x375A50", Offset = "0x374250", Length = "0xB5")]
	[Token(Token = "0x600297C")]
	public virtual RailResult HideTextInputWindow()
	{
		return default(RailResult);
	}
}
