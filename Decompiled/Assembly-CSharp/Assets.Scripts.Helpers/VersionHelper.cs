using System;
using Assets.Scripts.PeroTools.Managers;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;
using UnityEngine.Networking;

namespace Assets.Scripts.Helpers;

[Token(Token = "0x20006E7")]
public class VersionHelper
{
	[Token(Token = "0x4002508")]
	private static readonly string s_RootUrl;

	[Token(Token = "0x4002509")]
	private static bool s_NeedUpdateValue;

	[Token(Token = "0x400250A")]
	private static Timer s_CheckUpdateTimer;

	[Token(Token = "0x400250B")]
	private static bool s_IsPopConfirmShow;

	[Token(Token = "0x400250C")]
	private static readonly float s_CheckNetRequestDuration;

	[Token(Token = "0x6004144")]
	[Address(RVA = "0xC894D0", Offset = "0xC87CD0", Length = "0x240")]
	public static void CheckVersion(Action<bool> callback = null)
	{
	}

	[Token(Token = "0x6004145")]
	[Address(RVA = "0x526C70", Offset = "0x525470", Length = "0x3")]
	public static bool IsPlatformAvalible()
	{
		return default(bool);
	}

	[Token(Token = "0x6004146")]
	[Address(RVA = "0xC893E0", Offset = "0xC87BE0", Length = "0xED")]
	public static void CheckUpdateStateAndShowConfirm()
	{
	}

	[Address(RVA = "0xC8A140", Offset = "0xC88940", Length = "0xED")]
	[Token(Token = "0x6004147")]
	public static void ShowUpdateTip()
	{
	}

	[Token(Token = "0x6004148")]
	[Address(RVA = "0xC89360", Offset = "0xC87B60", Length = "0x78")]
	public static bool CheckNeedUpdate()
	{
		return default(bool);
	}

	[Token(Token = "0x6004149")]
	[Address(RVA = "0xC8A230", Offset = "0xC88A30", Length = "0x2EB")]
	public static void StartReqVersionTimer()
	{
	}

	[Address(RVA = "0xC8A520", Offset = "0xC88D20", Length = "0x14E")]
	[Token(Token = "0x600414A")]
	public static void StopReqVersionTimer()
	{
	}

	[Token(Token = "0x600414B")]
	[Address(RVA = "0xC89DE0", Offset = "0xC885E0", Length = "0x35E")]
	public static void ShowUpdateConfirmPopup()
	{
	}

	[Address(RVA = "0xC89A00", Offset = "0xC88200", Length = "0x54")]
	[Token(Token = "0x600414C")]
	public static void RedirectAppStore()
	{
	}

	[Token(Token = "0x600414D")]
	[Address(RVA = "0xC89750", Offset = "0xC87F50", Length = "0x134")]
	private static int GetVersionNumber(string versionStr)
	{
		return default(int);
	}

	[Token(Token = "0x600414E")]
	[Address(RVA = "0xC89890", Offset = "0xC88090", Length = "0x162")]
	private static void HandleVersionInfo(Action<bool> callback)
	{
	}

	[Token(Token = "0x600414F")]
	[Address(RVA = "0xC89230", Offset = "0xC87A30", Length = "0x120")]
	private static void AfterReqVersionInfoHandler(Action<JObject> callback)
	{
	}

	[Address(RVA = "0xC89A60", Offset = "0xC88260", Length = "0x371")]
	[Token(Token = "0x6004150")]
	private static void ReqVersionInfo(Action<DownloadHandler> sucessCallback, Action<long, string> failCallback = null)
	{
	}

	[Token(Token = "0x6004151")]
	[Address(RVA = "0xC89720", Offset = "0xC87F20", Length = "0x2B")]
	private static string GetPlatformName()
	{
		return null;
	}

	[Token(Token = "0x6004152")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public VersionHelper()
	{
	}
}
