using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;
using Steamworks;

namespace PeroPeroGames.DataStatistics;

[Token(Token = "0x20004F3")]
public class ThinkingDataSteamPurchase
{
	[Token(Token = "0x4001AC7")]
	[FieldOffset(Offset = "0x10")]
	private uint m_UnixTime;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001AC8")]
	private DateTime m_PurchaseTime;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001AC9")]
	private Dictionary<int, object> m_DLCDic;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001ACA")]
	private AppId_t m_AppId;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001ACB")]
	private string m_DLCname;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001ACC")]
	private bool m_Avaliable;

	[Token(Token = "0x4001ACD")]
	[FieldOffset(Offset = "0x3C")]
	public CSteamID steamUser;

	[Token(Token = "0x4001ACE")]
	[FieldOffset(Offset = "0x44")]
	public CSteamID steamOwner;

	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4001ACF")]
	public bool isSteamLogin;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001AD0")]
	private Dictionary<AppId_t, string> m_ChangetoProductID;

	[Token(Token = "0x4001AD1")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<string, object> m_PurchaseInfo;

	[Token(Token = "0x60036EF")]
	[Address(RVA = "0x505F00", Offset = "0x504700", Length = "0x39A")]
	public void Init()
	{
	}

	[Token(Token = "0x60036F0")]
	[Address(RVA = "0x5056D0", Offset = "0x503ED0", Length = "0x11A")]
	private void CheckUserDLC()
	{
	}

	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x72B90", Offset = "0x71F90")]
	[Token(Token = "0x60036F1")]
	[Address(RVA = "0x5057F0", Offset = "0x503FF0", Length = "0x65")]
	private IEnumerator CheckUserData()
	{
		return null;
	}

	[Token(Token = "0x60036F2")]
	[Address(RVA = "0x5064D0", Offset = "0x504CD0", Length = "0x395")]
	private void SetUserPurchaseTime()
	{
	}

	[Token(Token = "0x60036F3")]
	[Address(RVA = "0x505860", Offset = "0x504060", Length = "0x40F")]
	private void GetExternalDlcData(JObject jobject)
	{
	}

	[Token(Token = "0x60036F4")]
	[Address(RVA = "0x505C70", Offset = "0x504470", Length = "0x28F")]
	private void GetIAPProduct()
	{
	}

	[Address(RVA = "0x506940", Offset = "0x505140", Length = "0xD3")]
	[Token(Token = "0x60036F5")]
	public void SteamPurchaseInfo(Dictionary<string, object> infos)
	{
	}

	[Token(Token = "0x60036F6")]
	[Address(RVA = "0x5062A0", Offset = "0x504AA0", Length = "0x227")]
	public void SendPayment(string res)
	{
	}

	[Token(Token = "0x60036F7")]
	[Address(RVA = "0x506870", Offset = "0x505070", Length = "0xC2")]
	public void SteamLoginSucessful(string uid)
	{
	}

	[Token(Token = "0x60036F8")]
	[Address(RVA = "0x506EA0", Offset = "0x5056A0", Length = "0x96")]
	public ThinkingDataSteamPurchase()
	{
	}
}
