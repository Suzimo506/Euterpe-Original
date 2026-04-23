using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Networking;

[Token(Token = "0x2000080")]
public class SteamGoogleLogin : SingletonMonoBehaviour<SteamGoogleLogin>
{
	[Token(Token = "0x400034E")]
	[FieldOffset(Offset = "0x18")]
	private HttpListener listener;

	[Token(Token = "0x400034F")]
	[FieldOffset(Offset = "0x20")]
	private Thread listenerThread;

	[Token(Token = "0x4000350")]
	[FieldOffset(Offset = "0x28")]
	private UnityWebRequest m_WebRequest;

	[Token(Token = "0x4000351")]
	[FieldOffset(Offset = "0x30")]
	public bool m_IsGoogleLogin;

	[Token(Token = "0x4000352")]
	[FieldOffset(Offset = "0x38")]
	private string m_CallbackContext;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000353")]
	private string m_AccessToken;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000354")]
	private string m_IdToken;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000355")]
	private string m_OpenId;

	[Token(Token = "0x4000356")]
	[FieldOffset(Offset = "0x58")]
	private string m_Email;

	[Token(Token = "0x4000357")]
	[FieldOffset(Offset = "0x60")]
	private string m_Sid;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000358")]
	private bool m_RunCallback;

	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x4000359")]
	private bool m_RunGetOpenId;

	[Token(Token = "0x400035A")]
	[FieldOffset(Offset = "0x6A")]
	private bool m_RunTxwy;

	[Token(Token = "0x400035B")]
	private static bool m_IsInited;

	[FieldOffset(Offset = "0x6B")]
	[Token(Token = "0x400035C")]
	[SerializeField]
	private bool m_CanRunCallbackWebRequest;

	[Token(Token = "0x400035D")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_WhileRunCallbackWebRequest;

	[Token(Token = "0x400035E")]
	[FieldOffset(Offset = "0x6D")]
	private bool m_CanRunGetOpenIdRequest;

	[Token(Token = "0x400035F")]
	[FieldOffset(Offset = "0x6E")]
	private bool m_WhileRunGetOpenId;

	[Token(Token = "0x4000360")]
	[FieldOffset(Offset = "0x6F")]
	private bool m_CanRunTxwyRequest;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000361")]
	private bool m_WhileCanRunTxwy;

	[FieldOffset(Offset = "0x71")]
	[Token(Token = "0x4000362")]
	private bool m_WhileRunFail;

	[FieldOffset(Offset = "0x72")]
	[Token(Token = "0x4000363")]
	private bool m_StartListener;

	[Token(Token = "0x4000364")]
	[FieldOffset(Offset = "0x78")]
	private IAsyncResult m_Result;

	[Token(Token = "0x4000365")]
	[FieldOffset(Offset = "0x80")]
	private string m_Prefix;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000366")]
	private string base_login_url;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000367")]
	private string redirect_url;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000368")]
	private string scope;

	[Token(Token = "0x4000369")]
	[FieldOffset(Offset = "0xA0")]
	private string google_appID;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400036A")]
	private string google_appKey;

	[Token(Token = "0x400036B")]
	[FieldOffset(Offset = "0xB0")]
	private string stateKey;

	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400036C")]
	private string access_token_url;

	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400036D")]
	private string m_NewCode;

	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400036E")]
	private string m_NewState;

	[Token(Token = "0x400036F")]
	[FieldOffset(Offset = "0xD0")]
	private string m_CallbackDataBody;

	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000370")]
	private Dictionary<string, string> m_body;

	[Token(Token = "0x4000371")]
	[FieldOffset(Offset = "0xE0")]
	private bool m_IsCallbackCheckOver;

	[FieldOffset(Offset = "0xE1")]
	[Token(Token = "0x4000372")]
	private bool m_IsCallBackPostOver;

	[Token(Token = "0x4000373")]
	[FieldOffset(Offset = "0xE2")]
	private bool m_IsCallBackPostFail;

	[Token(Token = "0x4000374")]
	[FieldOffset(Offset = "0xE8")]
	private string m_AuthEmail;

	[Token(Token = "0x4000375")]
	[FieldOffset(Offset = "0xF0")]
	private string m_AuthUserId;

	[Token(Token = "0x4000376")]
	[FieldOffset(Offset = "0xF8")]
	private string m_BaseOpenIdUrl;

	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000377")]
	private bool m_IsGetOpenIdCheckOver;

	[FieldOffset(Offset = "0x101")]
	[Token(Token = "0x4000378")]
	private bool m_IsGetOpenIdRunOver;

	[Token(Token = "0x4000379")]
	[FieldOffset(Offset = "0x102")]
	private bool m_RunGetOpenIdFail;

	[Token(Token = "0x400037A")]
	[FieldOffset(Offset = "0x108")]
	private string m_TxwyId;

	[Token(Token = "0x400037B")]
	[FieldOffset(Offset = "0x110")]
	private string m_TxwyAppKey;

	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x400037C")]
	private string m_TxwyParams;

	[Token(Token = "0x400037D")]
	[FieldOffset(Offset = "0x120")]
	private bool m_IsGetTxwyCheckOver;

	[FieldOffset(Offset = "0x121")]
	[Token(Token = "0x400037E")]
	private bool m_IsGetTxwyRunOver;

	[FieldOffset(Offset = "0x122")]
	[Token(Token = "0x400037F")]
	private bool m_RunTxwyFail;

	[FieldOffset(Offset = "0x123")]
	[Token(Token = "0x4000380")]
	private bool m_IsRunPlayBackGameCheckOver;

	[FieldOffset(Offset = "0x124")]
	[Token(Token = "0x4000381")]
	public bool m_IsRunPlayBackGameOver;

	[Token(Token = "0x4000382")]
	[FieldOffset(Offset = "0x125")]
	private bool m_IsFinishToShow;

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x51A350", Offset = "0x518B50", Length = "0x5E")]
	private void Start()
	{
	}

	[Address(RVA = "0x519B10", Offset = "0x518310", Length = "0x1A3")]
	[Token(Token = "0x60003DD")]
	public void OnWebInit()
	{
	}

	[Address(RVA = "0x51A2A0", Offset = "0x518AA0", Length = "0xB0")]
	[Token(Token = "0x60003DE")]
	public void OpenWeb()
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x519AE0", Offset = "0x5182E0", Length = "0x29")]
	public void OnWebEnd()
	{
	}

	[Address(RVA = "0x51A5A0", Offset = "0x518DA0", Length = "0x4A")]
	[Token(Token = "0x60003E0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7A680", Offset = "0x79A80")]
	private IEnumerator WaitWebInit()
	{
		return null;
	}

	[Address(RVA = "0x51A3B0", Offset = "0x518BB0", Length = "0x1E7")]
	[Token(Token = "0x60003E1")]
	private void Update()
	{
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x51A730", Offset = "0x518F30", Length = "0x142")]
	private void startListener()
	{
	}

	[Address(RVA = "0x519AD0", Offset = "0x5182D0", Length = "0x5")]
	[Token(Token = "0x60003E3")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x5190D0", Offset = "0x5178D0", Length = "0x8A5")]
	[Token(Token = "0x60003E4")]
	private void ListenerCallback(IAsyncResult result)
	{
	}

	[Address(RVA = "0x517ED0", Offset = "0x5166D0", Length = "0x3EA")]
	[Token(Token = "0x60003E5")]
	private void IsCallBack(HttpListenerContext context)
	{
	}

	[Address(RVA = "0x519CC0", Offset = "0x5184C0", Length = "0x5D0")]
	[Token(Token = "0x60003E6")]
	private void OnWebRequestCompleted(AsyncOperation ao)
	{
	}

	[Address(RVA = "0x517E00", Offset = "0x516600", Length = "0xC6")]
	[Token(Token = "0x60003E7")]
	private void IsAuth(HttpListenerContext context)
	{
	}

	[Address(RVA = "0x517BA0", Offset = "0x5163A0", Length = "0xC5")]
	[Token(Token = "0x60003E8")]
	private void GetOpenId(HttpListenerContext context, string accessToken)
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x518B60", Offset = "0x517360", Length = "0x560")]
	private void IsTxwy(HttpListenerContext context)
	{
	}

	[Address(RVA = "0x518AE0", Offset = "0x5172E0", Length = "0x7A")]
	[Token(Token = "0x60003EA")]
	private void IsPlayBackGame(HttpListenerContext context)
	{
	}

	[Address(RVA = "0x517B90", Offset = "0x516390", Length = "0xE")]
	[Token(Token = "0x60003EB")]
	public void CheckIsGoogleLogin()
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x5186D0", Offset = "0x516ED0", Length = "0x40F")]
	private void IsFinish(HttpListenerContext context)
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x5182C0", Offset = "0x516AC0", Length = "0x40F")]
	private void IsFail(HttpListenerContext context)
	{
	}

	[Address(RVA = "0x519980", Offset = "0x518180", Length = "0x14B")]
	[Token(Token = "0x60003EE")]
	public string Md5Sum(string strToEncrypt)
	{
		return null;
	}

	[Address(RVA = "0x517C70", Offset = "0x516470", Length = "0x188")]
	[Token(Token = "0x60003EF")]
	private string GetRandomString()
	{
		return null;
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x51A5F0", Offset = "0x518DF0", Length = "0x137")]
	public SteamGoogleLogin()
	{
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
	}
}
