using System;
using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000090")]
public class SkinTimeLimitedFreeHandler : ITimeLimitedFreeHandler
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400039C")]
	private readonly Dictionary<int, KeyValuePair<DateTime, DateTime>> s_SkinTimeLimitedFreeCheck;

	[Address(RVA = "0x62F520", Offset = "0x62DD20", Length = "0x12E")]
	[Token(Token = "0x6000414")]
	public bool CheckTimeLimitedFreeInTime(int uid, int index)
	{
		return default(bool);
	}

	[Address(RVA = "0x62F2F0", Offset = "0x62DAF0", Length = "0x223")]
	[Token(Token = "0x6000415")]
	public void AddTimeLimitedFreeRecord(int uid, List<string> contentList, DateTime startTime, DateTime endTime)
	{
	}

	[Address(RVA = "0x62F650", Offset = "0x62DE50", Length = "0x43")]
	[Token(Token = "0x6000416")]
	public void ClearTimeLimitedFreeRecord()
	{
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0x62F6A0", Offset = "0x62DEA0", Length = "0x513")]
	public void ForceApplyTimeLimitedFree(int uid, List<string> contentList)
	{
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0x62FBC0", Offset = "0x62E3C0", Length = "0x60")]
	public void OnRefreshHandleEnd()
	{
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0x62FC30", Offset = "0x62E430", Length = "0x69")]
	public SkinTimeLimitedFreeHandler()
	{
	}
}
