using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Commons;
using Assets.Scripts.Structs.Network;
using Cpp2ILInjected;
using Discord;
using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000744")]
public class MainManager : SingletonMonoBehaviour<MainManager>
{
	[HideInInspector]
	[Token(Token = "0x400266A")]
	[FieldOffset(Offset = "0x18")]
	public DateTime dateTime;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400266D")]
	public global::Discord.Discord discord;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400266E")]
	private bool m_IsFirstInitLanguage;

	[Token(Token = "0x17000663")]
	public bool isFirstOpen
	{
		[CompilerGenerated]
		[Token(Token = "0x60043DD")]
		[Address(RVA = "0x45D430", Offset = "0x45BC30", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Token(Token = "0x60043DE")]
		[Address(RVA = "0x45D440", Offset = "0x45BC40", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x14000087")]
	public event Action<DateTime> onTimeChanged
	{
		[CompilerGenerated]
		[Token(Token = "0x60043DF")]
		[Address(RVA = "0x6D8450", Offset = "0x6D6C50", Length = "0x9E")]
		add
		{
		}
		[CompilerGenerated]
		[Address(RVA = "0x6D84F0", Offset = "0x6D6CF0", Length = "0x9E")]
		[Token(Token = "0x60043E0")]
		remove
		{
		}
	}

	[Token(Token = "0x60043E1")]
	[Address(RVA = "0x6D6B00", Offset = "0x6D5300", Length = "0xA05")]
	private void Init()
	{
	}

	[Token(Token = "0x60043E2")]
	[Address(RVA = "0x6D7510", Offset = "0x6D5D10", Length = "0x10A")]
	private void IntThinkingData()
	{
	}

	[Token(Token = "0x60043E3")]
	[Address(RVA = "0x6D4FF0", Offset = "0x6D37F0", Length = "0x4A")]
	private void InitForceUpdate()
	{
	}

	[Token(Token = "0x60043E4")]
	[Address(RVA = "0x6D63E0", Offset = "0x6D4BE0", Length = "0x1DC")]
	private void InitNetwork()
	{
	}

	[Token(Token = "0x60043E5")]
	[Address(RVA = "0x6D6190", Offset = "0x6D4990", Length = "0xF2")]
	private void InitNetworkCallback(JObject jObj)
	{
	}

	[Token(Token = "0x60043E6")]
	[Address(RVA = "0x6D6290", Offset = "0x6D4A90", Length = "0x14F")]
	private void InitNetworkFailCallback(NetworkRequest request)
	{
	}

	[Token(Token = "0x60043E7")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void InitNotificationPush()
	{
	}

	[Token(Token = "0x60043E8")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void InitOAID()
	{
	}

	[Token(Token = "0x60043E9")]
	[Address(RVA = "0x6D6A00", Offset = "0x6D5200", Length = "0xA0")]
	private void InitUI()
	{
	}

	[Address(RVA = "0x6D7730", Offset = "0x6D5F30", Length = "0xA8")]
	[Token(Token = "0x60043EA")]
	private void ResetButtonInvokeFlag(float _)
	{
	}

	[Address(RVA = "0x6D53C0", Offset = "0x6D3BC0", Length = "0x2D9")]
	[Token(Token = "0x60043EB")]
	private void InitIAP()
	{
	}

	[Address(RVA = "0x6D65C0", Offset = "0x6D4DC0", Length = "0x53")]
	[Token(Token = "0x60043EC")]
	private void InitPCIAP()
	{
	}

	[Address(RVA = "0x6D5320", Offset = "0x6D3B20", Length = "0x93")]
	[Token(Token = "0x60043ED")]
	private void InitIAPProduct(string[] buffer)
	{
	}

	[Address(RVA = "0x6D4D20", Offset = "0x6D3520", Length = "0x142")]
	[Token(Token = "0x60043EE")]
	private void InitCheckAdult()
	{
	}

	[Address(RVA = "0x6D6770", Offset = "0x6D4F70", Length = "0xA8")]
	[Token(Token = "0x60043EF")]
	private void InitServerTime()
	{
	}

	[Address(RVA = "0x6D52D0", Offset = "0x6D3AD0", Length = "0x4F")]
	[Token(Token = "0x60043F0")]
	private void InitHexie()
	{
	}

	[Token(Token = "0x60043F1")]
	[Address(RVA = "0x6D6AB0", Offset = "0x6D52B0", Length = "0x4F")]
	private void InitWeekFree()
	{
	}

	[Token(Token = "0x60043F2")]
	[Address(RVA = "0x6D4CD0", Offset = "0x6D34D0", Length = "0x43")]
	private void InitAnchor()
	{
	}

	[Token(Token = "0x60043F3")]
	[Address(RVA = "0x6D6070", Offset = "0x6D4870", Length = "0x11C")]
	private void InitMouse()
	{
	}

	[Token(Token = "0x60043F4")]
	[Address(RVA = "0x6D6710", Offset = "0x6D4F10", Length = "0x52")]
	private void InitReview()
	{
	}

	[Token(Token = "0x60043F5")]
	[Address(RVA = "0x6D4C60", Offset = "0x6D3460", Length = "0x64")]
	private void InitAccountSystem()
	{
	}

	[Token(Token = "0x60043F6")]
	[Address(RVA = "0x6D6820", Offset = "0x6D5020", Length = "0x2F")]
	private void InitStageInfo()
	{
	}

	[Token(Token = "0x60043F7")]
	[Address(RVA = "0x6D4E70", Offset = "0x6D3670", Length = "0x177")]
	public void InitController(bool firstTime = true)
	{
	}

	[Address(RVA = "0x6D5CB0", Offset = "0x6D44B0", Length = "0x3B8")]
	[Token(Token = "0x60043F8")]
	public void InitLoading(string key = "LoadingNull")
	{
	}

	[Token(Token = "0x60043F9")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void InitChannel()
	{
	}

	[Token(Token = "0x60043FA")]
	[Address(RVA = "0x6D6620", Offset = "0x6D4E20", Length = "0x52")]
	private void InitPlatforms()
	{
	}

	[Token(Token = "0x60043FB")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void InitDevices()
	{
	}

	[Token(Token = "0x60043FC")]
	[Address(RVA = "0x6D5730", Offset = "0x6D3F30", Length = "0x3A5")]
	private void InitLanguage()
	{
	}

	[Token(Token = "0x60043FD")]
	[Address(RVA = "0x6D6680", Offset = "0x6D4E80", Length = "0x80")]
	private void InitRegion()
	{
	}

	[Token(Token = "0x60043FE")]
	[Address(RVA = "0x6D5040", Offset = "0x6D3840", Length = "0x285")]
	private void InitGraphic()
	{
	}

	[Token(Token = "0x60043FF")]
	[Address(RVA = "0x6D68A0", Offset = "0x6D50A0", Length = "0x155")]
	private void InitTimer()
	{
	}

	[Token(Token = "0x6004400")]
	[Address(RVA = "0x6D6850", Offset = "0x6D5050", Length = "0x43")]
	private void InitTerminalModule()
	{
	}

	[Address(RVA = "0x6D77E0", Offset = "0x6D5FE0", Length = "0x42C")]
	[Token(Token = "0x6004401")]
	public void ScreenAdapte()
	{
	}

	[Token(Token = "0x6004402")]
	[Address(RVA = "0x6D7710", Offset = "0x6D5F10", Length = "0x1F")]
	private void OnSceneChange(Scene _, Scene scene)
	{
	}

	[Address(RVA = "0x6D4810", Offset = "0x6D3010", Length = "0x44A")]
	[Token(Token = "0x6004403")]
	private void AnimatorsInit()
	{
	}

	[Token(Token = "0x6004404")]
	[Address(RVA = "0x6D7620", Offset = "0x6D5E20", Length = "0xEB")]
	private void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x6004405")]
	[Address(RVA = "0x6D56A0", Offset = "0x6D3EA0", Length = "0x89")]
	public void InitLanguageFirst()
	{
	}

	[Token(Token = "0x6004406")]
	[Address(RVA = "0x6D5AE0", Offset = "0x6D42E0", Length = "0x1C1")]
	public void InitLevelConfigSaveData()
	{
	}

	[Token(Token = "0x6004407")]
	[Address(RVA = "0x6D8410", Offset = "0x6D6C10", Length = "0x38")]
	public MainManager()
	{
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
	}
}
