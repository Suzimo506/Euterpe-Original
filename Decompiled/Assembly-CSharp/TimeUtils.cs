using System;
using Cpp2ILInjected;

[Token(Token = "0x20001B0")]
public static class TimeUtils
{
	[Token(Token = "0x6000C1A")]
	[Address(RVA = "0x51F080", Offset = "0x51D880", Length = "0xB2")]
	public static long ConvertToTimestamp(DateTime dateTime)
	{
		return default(long);
	}

	[Token(Token = "0x6000C1B")]
	[Address(RVA = "0x51F140", Offset = "0x51D940", Length = "0x63")]
	public static bool IsInTime(DateTime time, DateTime startTime, DateTime endTime)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C1C")]
	[Address(RVA = "0x51F1B0", Offset = "0x51D9B0", Length = "0xC4")]
	public static bool IsStartAfterEnd(DateTime startTime, DateTime endTime)
	{
		return default(bool);
	}

	[Address(RVA = "0x51F280", Offset = "0x51DA80", Length = "0x27")]
	[Token(Token = "0x6000C1D")]
	public static DateTime TickToTime(long tick)
	{
		return default(DateTime);
	}
}
