using System;
using System.Collections.Generic;
using Account.Modules;
using Cpp2ILInjected;

namespace Assets.Scripts.Helpers;

[Token(Token = "0x20006E4")]
public class LoginHelper
{
	[Token(Token = "0x4002502")]
	private const string gameDataUrl = "api/v1/game_data";

	[Token(Token = "0x4002503")]
	private static AntiAddiction s_AntiAddiSession;

	[Token(Token = "0x4002504")]
	private static MinorPaymentLimit s_MinorPaymentLimit;

	[Token(Token = "0x17000600")]
	public static AntiAddiction antiAddiction
	{
		[Token(Token = "0x600411A")]
		[Address(RVA = "0xC84A50", Offset = "0xC83250", Length = "0x85")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000601")]
	public static MinorPaymentLimit MinorPaymentLimit
	{
		[Address(RVA = "0xC849C0", Offset = "0xC831C0", Length = "0x8B")]
		[Token(Token = "0x600411B")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0xC83E10", Offset = "0xC82610", Length = "0x2D")]
	[Token(Token = "0x600411C")]
	public static bool CompareVersionEqualsOrLargerThan(string versionCode)
	{
		return default(bool);
	}

	[Token(Token = "0x600411D")]
	[Address(RVA = "0xC83FF0", Offset = "0xC827F0", Length = "0x232")]
	public static void ReqLoginEntryInfo(Action<Dictionary<string, bool>, Dictionary<string, bool>> callback = null, Action<long, string> failedCallback = null, bool controlOverlay = true)
	{
	}

	[Token(Token = "0x600411E")]
	[Address(RVA = "0xC83E40", Offset = "0xC82640", Length = "0x1A1")]
	public static void GetGameDatas(string phoneOrEmailStr, string strType, Action<AccountGameDatas> successCall, Action<long, string> failedCall = null)
	{
	}

	[Token(Token = "0x600411F")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public LoginHelper()
	{
	}
}
