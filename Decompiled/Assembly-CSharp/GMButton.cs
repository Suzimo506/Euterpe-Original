using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000129")]
public class GMButton : MonoBehaviour
{
	[Flags]
	[Token(Token = "0x2000A1D")]
	private enum GMButtonSwtich
	{
		[Token(Token = "0x400360F")]
		none = 0,
		[Token(Token = "0x4003610")]
		reset_all = 1,
		[Token(Token = "0x4003611")]
		fps_display = 2,
		[Token(Token = "0x4003612")]
		auto_fight = 4,
		[Token(Token = "0x4003613")]
		level_upgrade_one = 8,
		[Token(Token = "0x4003614")]
		unlock_base = 0x10,
		[Token(Token = "0x4003615")]
		logout_test_account = 0x20,
		[Token(Token = "0x4003616")]
		reset_steam = 0x40
	}

	[Token(Token = "0x400074E")]
	[FieldOffset(Offset = "0x18")]
	private GMButtonSwtich m_GMButtonSwitch;

	[Token(Token = "0x400074F")]
	[FieldOffset(Offset = "0x20")]
	public GameObject GO_ResetAll;

	[Token(Token = "0x4000750")]
	[FieldOffset(Offset = "0x28")]
	public GameObject GO_FPSDisplay;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000751")]
	public GameObject GO_AutoFight;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000752")]
	public GameObject GO_LevelUpgradeOne;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000753")]
	public GameObject GO_UnlockBase;

	[Token(Token = "0x4000754")]
	[FieldOffset(Offset = "0x48")]
	public GameObject GO_LogoutTestAccount;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000755")]
	public GameObject GO_ResetAllSteam;

	[Token(Token = "0x6000866")]
	[Address(RVA = "0x840CC0", Offset = "0x83F4C0", Length = "0x1B5")]
	private void Start()
	{
	}

	[Token(Token = "0x6000867")]
	[Address(RVA = "0x8407C0", Offset = "0x83EFC0", Length = "0x166")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000868")]
	[Address(RVA = "0x840E80", Offset = "0x83F680", Length = "0xD0")]
	public void SwitchGMButton(int targetSwtich)
	{
	}

	[Token(Token = "0x6000869")]
	[Address(RVA = "0x840930", Offset = "0x83F130", Length = "0x166")]
	private void RegisterEvent()
	{
	}

	[Token(Token = "0x600086A")]
	[Address(RVA = "0x8407C0", Offset = "0x83EFC0", Length = "0x166")]
	private void UnregisterEvent()
	{
	}

	[Address(RVA = "0x840760", Offset = "0x83EF60", Length = "0x57")]
	[Token(Token = "0x600086B")]
	private void NotifyToFPSDisplayText(bool toggleValue)
	{
	}

	[Address(RVA = "0x840B40", Offset = "0x83F340", Length = "0x174")]
	[Token(Token = "0x600086C")]
	private void ResetTester()
	{
	}

	[Token(Token = "0x600086D")]
	[Address(RVA = "0x840AA0", Offset = "0x83F2A0", Length = "0x90")]
	private void ResetSteam()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600086E")]
	public GMButton()
	{
	}
}
