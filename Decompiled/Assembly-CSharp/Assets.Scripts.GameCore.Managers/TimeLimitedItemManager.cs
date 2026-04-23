using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Common;
using Assets.Scripts.Structs;
using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000759")]
public static class TimeLimitedItemManager
{
	[Token(Token = "0x40026E4")]
	private static readonly TimeLimitedItemArgs[] limitedItems;

	[Token(Token = "0x1700067A")]
	private static PeroServerTime serverTime
	{
		[Token(Token = "0x6004511")]
		[Address(RVA = "0x7DC7C0", Offset = "0x7DAFC0", Length = "0x2F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004512")]
	[Address(RVA = "0x7DBBC0", Offset = "0x7DA3C0", Length = "0x398")]
	public static bool IsItemInTime(string itemType, int itemIndex, bool needServerTime = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6004513")]
	[Address(RVA = "0x7DB390", Offset = "0x7D9B90", Length = "0x19D")]
	private static bool CheckItemArgsInTime(TimeLimitedItemArgs limitedItemArgs, bool needServerTime)
	{
		return default(bool);
	}

	[Token(Token = "0x6004514")]
	[Address(RVA = "0x7DC130", Offset = "0x7DA930", Length = "0x145")]
	private static bool TryGetTimeLimitedItemArgs(string itemType, int itemIndex, out TimeLimitedItemArgs itemArgs)
	{
		System.Runtime.CompilerServices.Unsafe.As<TimeLimitedItemArgs, @null>(ref itemArgs) = null;
		return default(bool);
	}

	[Token(Token = "0x6004515")]
	[Address(RVA = "0x7DB950", Offset = "0x7DA150", Length = "0x26E")]
	public static bool GetTimeOutItemArgs(List<TimeLimitedItemArgs> container)
	{
		return default(bool);
	}

	[Token(Token = "0x6004516")]
	[Address(RVA = "0x7DBF60", Offset = "0x7DA760", Length = "0x1CB")]
	public static void TimeoutItemFiliter(string itemType, List<int> itemIndexs)
	{
	}

	[Token(Token = "0x6004517")]
	[Address(RVA = "0x7DB530", Offset = "0x7D9D30", Length = "0x412")]
	public static void GetTimeInFreeLoadingIndex(List<int> timeLimitFreeGetloadingIndexs)
	{
	}
}
