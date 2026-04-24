using System;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000253")]
public class IRailStatisticHelperImpl : RailObject, IRailStatisticHelper
{
	[Token(Token = "0x600294C")]
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	internal IRailStatisticHelperImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x600294D")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailStatisticHelperImpl()
	{
	}

	[Address(RVA = "0x373000", Offset = "0x371800", Length = "0x209")]
	[Token(Token = "0x600294E")]
	public virtual IRailPlayerStats CreatePlayerStats(RailID player)
	{
		return null;
	}

	[Token(Token = "0x600294F")]
	[Address(RVA = "0x373210", Offset = "0x371A10", Length = "0xFF")]
	public virtual IRailGlobalStats GetGlobalStats()
	{
		return null;
	}

	[Token(Token = "0x6002950")]
	[Address(RVA = "0x372F20", Offset = "0x371720", Length = "0xDD")]
	public virtual RailResult AsyncGetNumberOfPlayer(string user_data)
	{
		return default(RailResult);
	}
}
