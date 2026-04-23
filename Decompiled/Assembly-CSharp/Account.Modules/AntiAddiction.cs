using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Assets.Scripts.PeroTools.Managers;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;
using UI.Controls;
using UnityEngine;

namespace Account.Modules;

[Token(Token = "0x2000566")]
public class AntiAddiction
{
	[Token(Token = "0x2000B89")]
	private enum HeartBeatResType
	{
		[Token(Token = "0x4003A8E")]
		Undefined = 0,
		[Token(Token = "0x4003A8F")]
		Heartbeat = 1,
		[Token(Token = "0x4003A90")]
		ServerRealCheckUnPass = 4,
		[Token(Token = "0x4003A91")]
		NotInPlayTime = 5,
		[Token(Token = "0x4003A92")]
		SessionIDExpired = 8
	}

	[Obsolete]
	[Token(Token = "0x4001FDE")]
	[FieldOffset(Offset = "0x20")]
	private Timer m_AntiAdditionTimer;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001FDF")]
	private float m_TimeDuration;

	[Token(Token = "0x4001FE0")]
	private const int init_count = 5;

	[Token(Token = "0x4001FE1")]
	[FieldOffset(Offset = "0x2C")]
	private int m_InitFailCount;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001FE2")]
	private Coroutine m_HeartBeatCorotine;

	[Obsolete]
	[Token(Token = "0x4001FE3")]
	[FieldOffset(Offset = "0x38")]
	private Task m_HeartBeatTask;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001FE4")]
	private CommonMessageBox m_NoAcitveMsgWindow;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001FE5")]
	private string m_InitUrl;

	[Token(Token = "0x4001FE6")]
	[FieldOffset(Offset = "0x50")]
	private string m_CheckAntiAddiUrl;

	[Token(Token = "0x17000516")]
	public string sessionId
	{
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		[Token(Token = "0x60037FF")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6003800")]
		[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000517")]
	public bool isActive
	{
		[CompilerGenerated]
		[Address(RVA = "0x470810", Offset = "0x46F010", Length = "0x5")]
		[Token(Token = "0x6003801")]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Token(Token = "0x6003802")]
		[Address(RVA = "0x470820", Offset = "0x46F020", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000518")]
	public bool isInited
	{
		[Address(RVA = "0x5A33B0", Offset = "0x5A1BB0", Length = "0x16")]
		[Token(Token = "0x6003803")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000519")]
	public bool isNotInGametime
	{
		[Address(RVA = "0x575490", Offset = "0x573C90", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6003804")]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Token(Token = "0x6003805")]
		[Address(RVA = "0x575860", Offset = "0x574060", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x6003806")]
	[Address(RVA = "0x774C50", Offset = "0x773450", Length = "0x6C")]
	public AntiAddiction()
	{
	}

	[Token(Token = "0x6003807")]
	[Address(RVA = "0x774370", Offset = "0x772B70", Length = "0x100")]
	public void Init(Action callback = null)
	{
	}

	[Token(Token = "0x6003808")]
	[Address(RVA = "0x774480", Offset = "0x772C80", Length = "0x33")]
	public void Release()
	{
	}

	[Token(Token = "0x6003809")]
	[Address(RVA = "0x7748E0", Offset = "0x7730E0", Length = "0x1B9")]
	public void ShowNotInPlaytimeConfirmWindow(string msg = null)
	{
	}

	[Address(RVA = "0x774680", Offset = "0x772E80", Length = "0x258")]
	[Token(Token = "0x600380A")]
	public void ShowNoActiveAntiSystemWindow(string msg = null)
	{
	}

	[Address(RVA = "0x774220", Offset = "0x772A20", Length = "0x99")]
	[Token(Token = "0x600380B")]
	public void CloseNoActiveAntiSystemWindow()
	{
	}

	[Token(Token = "0x600380C")]
	[Address(RVA = "0x774AA0", Offset = "0x7732A0", Length = "0xBD")]
	public void StartAntiAdditionTimer()
	{
	}

	[Token(Token = "0x600380D")]
	[Address(RVA = "0x774B60", Offset = "0x773360", Length = "0x76")]
	public void StopAntiAdditionTimer()
	{
	}

	[Token(Token = "0x600380E")]
	[Address(RVA = "0x774630", Offset = "0x772E30", Length = "0x46")]
	private void SetSessionId(string context)
	{
	}

	[Address(RVA = "0x7742C0", Offset = "0x772AC0", Length = "0xAD")]
	[Token(Token = "0x600380F")]
	private void InitRetry()
	{
	}

	[Address(RVA = "0x7744C0", Offset = "0x772CC0", Length = "0x16A")]
	[Token(Token = "0x6003810")]
	private void ReqIsInGameplayTime(Action<JObject> successCallback, Action<long, string> failCallback = null)
	{
	}

	[Address(RVA = "0x5A0EF0", Offset = "0x59F6F0", Length = "0x7")]
	[Token(Token = "0x6003811")]
	private void QuitConfirm()
	{
	}

	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	[Token(Token = "0x6003812")]
	private bool IsPlatformAvalible()
	{
		return default(bool);
	}
}
