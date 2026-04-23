using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace PeroPeroGames.DataStatistics;

[Token(Token = "0x20004F6")]
public static class UserProperty
{
	[Token(Token = "0x4001AD9")]
	public static string driverId;

	[Token(Token = "0x4001ADA")]
	public static string appVersion;

	[Token(Token = "0x4001ADB")]
	public static string networkType;

	[Token(Token = "0x4001ADC")]
	public static string platforms;

	[Token(Token = "0x4001ADD")]
	public static string channel;

	[Token(Token = "0x4001ADE")]
	public static string accountId;

	[Token(Token = "0x4001ADF")]
	public static string userName;

	[Token(Token = "0x4001AE0")]
	public static DateTime firstLoginTime;

	[Token(Token = "0x4001AE1")]
	public static DateTime lastLoginTime;

	[Token(Token = "0x4001AE2")]
	public static DateTime firstPurchaseTime;

	[Token(Token = "0x4001AE3")]
	public static DateTime lastPurchaseTime;

	[Token(Token = "0x4001AE4")]
	public static float accumulativePurchaseAmount;

	[Token(Token = "0x4001AE5")]
	public static int purchaseCount;

	[Token(Token = "0x4001AE6")]
	public static int consecutiveLoginDays;

	[Token(Token = "0x4001AE7")]
	public static int accumulativeLoginDays;

	[Token(Token = "0x4001AE8")]
	public static float ability;

	[Token(Token = "0x4001AE9")]
	public static int userLevel;

	[Token(Token = "0x4001AEA")]
	public static float currentPurchaseAmount;

	[Token(Token = "0x4001AEB")]
	public static int currentPurchaseCount;

	[Token(Token = "0x4001AEC")]
	public static long severTimeSpan;

	[Token(Token = "0x4001AED")]
	public static string language;

	[Token(Token = "0x4001AEE")]
	public static bool is_login;

	[Token(Token = "0x4001AEF")]
	public static string user_type;

	[Token(Token = "0x4001AF0")]
	public static int old_ability;

	[Token(Token = "0x4001AF1")]
	public static int reach_ability;

	[Token(Token = "0x4001AF2")]
	public static DateTime change_time;

	[Token(Token = "0x4001AF3")]
	public static DateTime previous_change_time;

	[Token(Token = "0x4001AF4")]
	public static int time_zone;

	[Token(Token = "0x4001AF5")]
	public static string shop_page_name;

	[Token(Token = "0x4001AF6")]
	public static Dictionary<string, object> shushuBaseInfo;

	[Token(Token = "0x4001AF7")]
	public static List<Dictionary<string, object>> productInfoList;

	[Token(Token = "0x17000502")]
	public static string os
	{
		[CompilerGenerated]
		[Address(RVA = "0x5091E0", Offset = "0x5079E0", Length = "0x39")]
		[Token(Token = "0x6003703")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Address(RVA = "0x509220", Offset = "0x507A20", Length = "0x49")]
		[Token(Token = "0x6003704")]
		set
		{
		}
	}
}
