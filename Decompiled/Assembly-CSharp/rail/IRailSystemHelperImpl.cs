using System;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000256")]
public class IRailSystemHelperImpl : RailObject, IRailSystemHelper
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x6002974")]
	internal IRailSystemHelperImpl(IntPtr cPtr)
	{
	}

	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	[Token(Token = "0x6002975")]
	~IRailSystemHelperImpl()
	{
	}

	[Address(RVA = "0x3757A0", Offset = "0x373FA0", Length = "0xC2")]
	[Token(Token = "0x6002976")]
	public virtual RailResult SetTerminationTimeoutOwnershipExpired(int timeout_seconds)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x3756E0", Offset = "0x373EE0", Length = "0xB5")]
	[Token(Token = "0x6002977")]
	public virtual RailSystemState GetPlatformSystemState()
	{
		return default(RailSystemState);
	}
}
