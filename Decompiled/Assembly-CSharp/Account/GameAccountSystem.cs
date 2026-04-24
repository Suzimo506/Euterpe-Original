using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Threading;
using Assets.Scripts.Common;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;
using Pb;
using PeroTools2.Account;
using PeroTools2.Commons;
using UnityEngine;
using UnityEngine.Networking;

namespace Account;

[Token(Token = "0x200055F")]
public class GameAccountSystem : AccountSystem
{
	[Token(Token = "0x4001FA9")]
	private const int call_xd_panel_fail = 1;

	[Token(Token = "0x4001FAA")]
	private const int call_xd_http_fail = 2;

	[Token(Token = "0x4001FAB")]
	private const int call_pero_http_fail = 3;

	[Token(Token = "0x4001FAC")]
	private const int call_3rd_fail = 4;

	[Token(Token = "0x4001FAD")]
	public static readonly string XD_LOGIN_TOKEN_KEY;

	[Token(Token = "0x4001FAE")]
	public const string proto_realname_phone_send_code = "api/v1/me/gov/send_phone_code";

	[Token(Token = "0x4001FAF")]
	public const string proto_realname_bind_phone = "api/v1/me/gov/bind_phone";

	[Token(Token = "0x4001FB0")]
	public const string proto_sdk_controller_login_board = "/api/musedash/v1/sdk_controller/login_board";

	[Token(Token = "0x4001FB1")]
	[FieldOffset(Offset = "0x58")]
	public bool showTip;

	[Token(Token = "0x4001FB2")]
	private static GameAccountSystem s_Instance;

	[NonSerialized]
	[Token(Token = "0x4001FB6")]
	[FieldOffset(Offset = "0x60")]
	public UserBindInfo jObjUserInfo;

	[NonSerialized]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001FB7")]
	public JObject jObjLoginInfo;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001FB8")]
	private ClientWebSocket m_WebSocket;

	[Token(Token = "0x4001FB9")]
	[FieldOffset(Offset = "0x78")]
	private CancellationToken m_CancellationToken;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001FBA")]
	public Action<WebSocketState> onWebSocketState;

	[Token(Token = "0x4001FBB")]
	[FieldOffset(Offset = "0x88")]
	public Action onConnectError;

	[Token(Token = "0x4001FBC")]
	[FieldOffset(Offset = "0x90")]
	public Action<string> onMessage;

	[Token(Token = "0x1700050A")]
	public bool isWechatInstalled
	{
		[Token(Token = "0x6003788")]
		[Address(RVA = "0x526C70", Offset = "0x525470", Length = "0x3")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700050B")]
	public AccountPlatform platform
	{
		[Token(Token = "0x6003789")]
		[Address(RVA = "0x77A570", Offset = "0x778D70", Length = "0x19")]
		get
		{
			return default(AccountPlatform);
		}
	}

	[Token(Token = "0x1700050C")]
	public bool hasXdAccessToken
	{
		[Token(Token = "0x600378A")]
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700050D")]
	public string platform_name
	{
		[Address(RVA = "0x77A590", Offset = "0x778D90", Length = "0x84")]
		[Token(Token = "0x600378B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700050E")]
	public static GameAccountSystem instance
	{
		[Address(RVA = "0x77A300", Offset = "0x778B00", Length = "0x18F")]
		[Token(Token = "0x600378C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700050F")]
	public new bool isOversea
	{
		[Token(Token = "0x600378D")]
		[Address(RVA = "0x526C70", Offset = "0x525470", Length = "0x3")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000510")]
	public new UserInfo userInfo
	{
		[Token(Token = "0x600378E")]
		[Address(RVA = "0x77A620", Offset = "0x778E20", Length = "0x5D")]
		get
		{
			return default(UserInfo);
		}
	}

	[Token(Token = "0x17000511")]
	public bool isInited
	{
		[Address(RVA = "0x77A490", Offset = "0x778C90", Length = "0x5")]
		[Token(Token = "0x6003790")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Address(RVA = "0x77A680", Offset = "0x778E80", Length = "0x4")]
		[Token(Token = "0x600378F")]
		private set
		{
		}
	}

	[Token(Token = "0x17000512")]
	public bool isXDSDKInited
	{
		[CompilerGenerated]
		[Address(RVA = "0x77A560", Offset = "0x778D60", Length = "0x5")]
		[Token(Token = "0x6003792")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003791")]
		[CompilerGenerated]
		[Address(RVA = "0x77A880", Offset = "0x779080", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000513")]
	public bool isOnActive
	{
		[CompilerGenerated]
		[Address(RVA = "0x77A4A0", Offset = "0x778CA0", Length = "0x5")]
		[Token(Token = "0x6003793")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x77A690", Offset = "0x778E90", Length = "0x4")]
		[Token(Token = "0x6003794")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000514")]
	public bool isOverSeaFromPlayerPrefs
	{
		[Address(RVA = "0x77A4B0", Offset = "0x778CB0", Length = "0xAD")]
		[Token(Token = "0x60037A8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60037A9")]
		[Address(RVA = "0x77A6A0", Offset = "0x778EA0", Length = "0x1DA")]
		set
		{
		}
	}

	[Token(Token = "0x6003784")]
	[Address(RVA = "0x778C00", Offset = "0x777400", Length = "0x323")]
	public void SendLoginFail(string errSdkMsg, int code, int type, UnityWebRequest request, Action<JObject> succeedCallback = null, Action<long, string> faillCallback = null)
	{
	}

	[Address(RVA = "0x778AB0", Offset = "0x7772B0", Length = "0x147")]
	[Token(Token = "0x6003785")]
	public void SendFavoriteMusic(List<string> uidsBuffer, string addMusicUid = "", string removeMusicUid = "", Action<JObject> succeedCallback = null, Action<long, string> faillCallback = null)
	{
	}

	[Token(Token = "0x6003786")]
	[Address(RVA = "0x779080", Offset = "0x777880", Length = "0x147")]
	public void SendLoveRoles(List<string> uidsBuffer, string addCharacterUid = "", string removeCharacter = "", Action<JObject> succeedCallback = null, Action<long, string> faillCallback = null)
	{
	}

	[Address(RVA = "0x778F30", Offset = "0x777730", Length = "0x147")]
	[Token(Token = "0x6003787")]
	public void SendLoveElfins(List<string> uidsBuffer, string addElfUid = "", string removeElfUid = "", Action<JObject> succeedCallback = null, Action<long, string> faillCallback = null)
	{
	}

	[Address(RVA = "0x776680", Offset = "0x774E80", Length = "0x244")]
	[Token(Token = "0x6003795")]
	public void Init(string settingName)
	{
	}

	[Token(Token = "0x6003796")]
	[Address(RVA = "0x776040", Offset = "0x774840", Length = "0x63E")]
	public void InitXdsdk(bool registEvents = false)
	{
	}

	[Address(RVA = "0x775B90", Offset = "0x774390", Length = "0x4AA")]
	[Token(Token = "0x6003797")]
	private string[] GetXdLoginEntryList(bool showAppleLogin = true)
	{
		return null;
	}

	[Token(Token = "0x6003798")]
	[Address(RVA = "0x7754B0", Offset = "0x773CB0", Length = "0x171")]
	public SystemLanguage GetLanguage()
	{
		return default(SystemLanguage);
	}

	[Token(Token = "0x6003799")]
	[Address(RVA = "0x77A0F0", Offset = "0x7788F0", Length = "0x22")]
	public void UpdateLanguage()
	{
	}

	[Address(RVA = "0x776B40", Offset = "0x775340", Length = "0x77")]
	[Token(Token = "0x600379A")]
	public void Login()
	{
	}

	[Address(RVA = "0x778680", Offset = "0x776E80", Length = "0xE")]
	[Token(Token = "0x600379B")]
	public new void PhoneEmailLogin(string loginPlatform, string number, string code)
	{
	}

	[Address(RVA = "0x779CF0", Offset = "0x7784F0", Length = "0x8")]
	[Token(Token = "0x600379C")]
	public new void ThirdPartLogin(string _platform, int androidAPILevel = -1)
	{
	}

	[Token(Token = "0x600379D")]
	[Address(RVA = "0x776920", Offset = "0x775120", Length = "0x55")]
	public new bool IsLoggedIn()
	{
		return default(bool);
	}

	[Token(Token = "0x600379E")]
	[Address(RVA = "0x777870", Offset = "0x776070", Length = "0x135")]
	public void OnLoginSuccess(string accessToken)
	{
	}

	[Token(Token = "0x600379F")]
	[Address(RVA = "0x777AD0", Offset = "0x7762D0", Length = "0xF8")]
	public void OnPCOverseasLoginSucceed(string openid, string p)
	{
	}

	[Token(Token = "0x60037A0")]
	[Address(RVA = "0x777390", Offset = "0x775B90", Length = "0x4DF")]
	private void OnLoginFinished(JObject jObj)
	{
	}

	[Token(Token = "0x60037A1")]
	[Address(RVA = "0x7779B0", Offset = "0x7761B0", Length = "0x118")]
	public void OnOverseasLoginSucceed(string sid)
	{
	}

	[Token(Token = "0x60037A2")]
	[Address(RVA = "0x776BC0", Offset = "0x7753C0", Length = "0x50D")]
	public new void Logout()
	{
	}

	[Token(Token = "0x60037A3")]
	[Address(RVA = "0x779D00", Offset = "0x778500", Length = "0x7")]
	public void TotalLogout()
	{
	}

	[Token(Token = "0x60037A4")]
	[Address(RVA = "0x7798B0", Offset = "0x7780B0", Length = "0x132")]
	public void SetPlayerName(string nickName, Action<int> callback, Action<long, string> failCallback)
	{
	}

	[Token(Token = "0x60037A5")]
	[Address(RVA = "0x776980", Offset = "0x775180", Length = "0x157")]
	public void IsRealName(Action<bool, bool> callback)
	{
	}

	[Token(Token = "0x60037A6")]
	[Address(RVA = "0x778300", Offset = "0x776B00", Length = "0x2F7")]
	public void OpenRealName(Action failCallback, Action succeedCallback)
	{
	}

	[Token(Token = "0x60037A7")]
	[Address(RVA = "0x775A90", Offset = "0x774290", Length = "0xF0")]
	public Coroutine GetUserInfo(Action callback = null)
	{
		return null;
	}

	[Token(Token = "0x60037AA")]
	[Address(RVA = "0x7768D0", Offset = "0x7750D0", Length = "0x41")]
	public bool IsBind()
	{
		return default(bool);
	}

	[Token(Token = "0x60037AB")]
	[Address(RVA = "0x776AE0", Offset = "0x7752E0", Length = "0x48")]
	public bool IsUserOverseas()
	{
		return default(bool);
	}

	[Token(Token = "0x60037AC")]
	[Address(RVA = "0x7770D0", Offset = "0x7758D0", Length = "0x2B5")]
	protected override bool OnHeartbeat(HeartbeatResp req)
	{
		return default(bool);
	}

	[Token(Token = "0x60037AD")]
	[Address(RVA = "0x7799F0", Offset = "0x7781F0", Length = "0x7")]
	public new void StartHeartbeat()
	{
	}

	[Token(Token = "0x60037AE")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x806B0", Offset = "0x7FAB0")]
	[Address(RVA = "0x779A00", Offset = "0x778200", Length = "0xCB")]
	public void StartWebSocket()
	{
	}

	[Address(RVA = "0x779670", Offset = "0x777E70", Length = "0x237")]
	[Token(Token = "0x60037AF")]
	public void Send(int type)
	{
	}

	[Address(RVA = "0x779AD0", Offset = "0x7782D0", Length = "0x1B")]
	[Token(Token = "0x60037B0")]
	public void StopWebSocket()
	{
	}

	[Token(Token = "0x60037B1")]
	[Address(RVA = "0x7756B0", Offset = "0x773EB0", Length = "0x21B")]
	public void GetRanks(string musicUid, int difficulty, Action<JToken, JToken, int> callback, Action<long, string> failCallback)
	{
	}

	[Address(RVA = "0x77A120", Offset = "0x778920", Length = "0x19A")]
	[Token(Token = "0x60037B2")]
	public void UploadScore(SceneUploadResultData resData, List<Beat> beats, Action<int> callback)
	{
	}

	[Token(Token = "0x60037B3")]
	[Address(RVA = "0x7786A0", Offset = "0x776EA0", Length = "0x309")]
	private Dictionary<string, object> PrepareUploadScore(SceneUploadResultData resData, List<Beat> beats)
	{
		return null;
	}

	[Token(Token = "0x60037B4")]
	[Address(RVA = "0x7751F0", Offset = "0x7739F0", Length = "0x2A4")]
	public string GetDeviceID()
	{
		return null;
	}

	[Address(RVA = "0x779AF0", Offset = "0x7782F0", Length = "0x1FF")]
	[Token(Token = "0x60037B5")]
	public void Synchronize()
	{
	}

	[Address(RVA = "0x777BD0", Offset = "0x7763D0", Length = "0x726")]
	[Token(Token = "0x60037B6")]
	public void OnSaveSelectCallback(bool isLocal, Dictionary<string, IData> datas, JToken jsonDatas, Action callback = null)
	{
	}

	[Token(Token = "0x60037B7")]
	[Address(RVA = "0x7789B0", Offset = "0x7771B0", Length = "0xF2")]
	public void RefreshDatas()
	{
	}

	[Address(RVA = "0x7758D0", Offset = "0x7740D0", Length = "0x7C")]
	[Token(Token = "0x60037B8")]
	public void GetSaveDataFromCloud(Action<JObject> successCallback, Action<long, string> failCallback = null)
	{
	}

	[Token(Token = "0x60037B9")]
	[Address(RVA = "0x775630", Offset = "0x773E30", Length = "0x7C")]
	public void GetProfileFromCloud(Action<JObject> successCallback, Action<long, string> failCallback = null)
	{
	}

	[Token(Token = "0x60037BA")]
	[Address(RVA = "0x778690", Offset = "0x776E90", Length = "0xE")]
	public void PhoneMailBind(Action<string> succeed = null, Action<int, string> failed = null, Action started = null, Action completed = null)
	{
	}

	[Address(RVA = "0x775950", Offset = "0x774150", Length = "0x132")]
	[Token(Token = "0x60037BB")]
	public void GetTime(Action<DateTime> callback)
	{
	}

	[Address(RVA = "0x7754A0", Offset = "0x773CA0", Length = "0x7")]
	[Token(Token = "0x60037BC")]
	public new string GetHost()
	{
		return null;
	}

	[Token(Token = "0x60037BD")]
	[Address(RVA = "0x7794A0", Offset = "0x777CA0", Length = "0x1CE")]
	public WebUtils.PeroWebRequest SendToUserUrl(string url, string method = "GET", Dictionary<string, object> datas = null, Action<JObject> succeedCallback = null, Action<long, string> faillCallback = null, Action startCallback = null, Action completeCallback = null, Dictionary<string, string> headers = null)
	{
		return null;
	}

	[Token(Token = "0x60037BE")]
	[Address(RVA = "0x779310", Offset = "0x777B10", Length = "0x18B")]
	public WebUtils.PeroWebRequest SendToUrl(string url, string method = "GET", Dictionary<string, object> datas = null, Action<JObject> succeedCallback = null, Action<long, string> faillCallback = null, Action startCallback = null, Action completeCallback = null, Dictionary<string, string> headers = null)
	{
		return null;
	}

	[Token(Token = "0x60037BF")]
	[Address(RVA = "0x774F20", Offset = "0x773720", Length = "0x2CD")]
	public WebUtils.PeroWebRequest CommonToUrl(string server_ip, string url, string method = "GET", Dictionary<string, object> datas = null, Action<JObject> succeedCallback = null, Action<long, string> faillCallback = null, Action startCallback = null, Action completeCallback = null, Dictionary<string, string> headers = null)
	{
		return null;
	}

	[Token(Token = "0x60037C0")]
	[Address(RVA = "0x778600", Offset = "0x776E00", Length = "0x77")]
	public void Pay(string productId, int price, string selectDiscount, int realnameType = 0, int adultType = 0, string extra = null, Action popupShutCallback = null, Action<string> succeed = null, Action<int, string> failed = null, Action started = null, Action completed = null)
	{
	}

	[Token(Token = "0x60037C1")]
	[Address(RVA = "0x774E20", Offset = "0x773620", Length = "0xFC")]
	public void CheckPayment(Action<JObject> succeedCallback, Action<long, string> failCallback)
	{
	}

	[Token(Token = "0x60037C2")]
	[Address(RVA = "0x7791D0", Offset = "0x7779D0", Length = "0x13E")]
	public void SendRealNamePhoneCode(string phoneNumber, Action<JObject> successCallback, Action<long, string> failCallback)
	{
	}

	[Token(Token = "0x60037C3")]
	[Address(RVA = "0x774CC0", Offset = "0x7734C0", Length = "0x15B")]
	public void BindRealNamePhone(string phoneNumber, string verifyCode, Action<JObject> successCallback, Action<long, string> failCallback)
	{
	}

	[Address(RVA = "0x4F9670", Offset = "0x4F7E70", Length = "0x7")]
	[Token(Token = "0x60037C4")]
	public GameAccountSystem()
	{
	}
}
