using System;
using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000091")]
public class StageBackgroundTimeLimitedFreeHandler : ITimeLimitedFreeHandler
{
	[Token(Token = "0x20009CA")]
	private struct StageBackgroundLimitFreeData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003504")]
		public int uid;

		[Token(Token = "0x4003505")]
		[FieldOffset(Offset = "0x8")]
		public List<string> contentList;

		[Token(Token = "0x4003506")]
		[FieldOffset(Offset = "0x10")]
		public DateTime startTime;

		[Token(Token = "0x4003507")]
		[FieldOffset(Offset = "0x18")]
		public DateTime endTime;
	}

	[Token(Token = "0x400039D")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, StageBackgroundLimitFreeData> m_Data;

	[Address(RVA = "0x515950", Offset = "0x514150", Length = "0x69")]
	[Token(Token = "0x600041A")]
	public StageBackgroundTimeLimitedFreeHandler()
	{
	}

	[Address(RVA = "0x5156C0", Offset = "0x513EC0", Length = "0xBF")]
	[Token(Token = "0x600041B")]
	public void AddTimeLimitedFreeRecord(int uid, List<string> contentList, DateTime startTime, DateTime endTime)
	{
	}

	[Token(Token = "0x600041C")]
	[Address(RVA = "0x5158F0", Offset = "0x5140F0", Length = "0x55")]
	public void ForceApplyTimeLimitedFree(int uid, List<string> contentList)
	{
	}

	[Address(RVA = "0x5158A0", Offset = "0x5140A0", Length = "0x43")]
	[Token(Token = "0x600041D")]
	public void ClearTimeLimitedFreeRecord()
	{
	}

	[Address(RVA = "0x515780", Offset = "0x513F80", Length = "0x11B")]
	[Token(Token = "0x600041E")]
	public bool CheckTimeLimitedFreeInTime(int uid, int index)
	{
		return default(bool);
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x600041F")]
	public void OnRefreshHandleEnd()
	{
	}
}
