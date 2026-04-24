using System;
using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x200008E")]
public class CharacterTimeLimitedFreeHandler : ITimeLimitedFreeHandler
{
	[Token(Token = "0x400039B")]
	[FieldOffset(Offset = "0x10")]
	private readonly Dictionary<int, KeyValuePair<DateTime, DateTime>> s_CharacterTimeLimitedFreeCheck;

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x466150", Offset = "0x464950", Length = "0x116")]
	public bool CheckTimeLimitedFreeInTime(int uid, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x4660B0", Offset = "0x4648B0", Length = "0x92")]
	public void AddTimeLimitedFreeRecord(int uid, List<string> contentList, DateTime startTime, DateTime endTime)
	{
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0x466270", Offset = "0x464A70", Length = "0x43")]
	public void ClearTimeLimitedFreeRecord()
	{
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x4662C0", Offset = "0x464AC0", Length = "0x4F")]
	public void ForceApplyTimeLimitedFree(int uid, List<string> contentList)
	{
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void OnRefreshHandleEnd()
	{
	}

	[Address(RVA = "0x466310", Offset = "0x464B10", Length = "0x69")]
	[Token(Token = "0x600040E")]
	public CharacterTimeLimitedFreeHandler()
	{
	}
}
