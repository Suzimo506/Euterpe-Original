using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.PeroTools.PreWarm;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000B9")]
public class PnlVictory : MonoBehaviour, IPreWarm
{
	[Token(Token = "0x40004CE")]
	[FieldOffset(Offset = "0x18")]
	public float scoreRollTime;

	[Token(Token = "0x40004CF")]
	[FieldOffset(Offset = "0x20")]
	public GameObject pnlVictory;

	[Token(Token = "0x40004D0")]
	[FieldOffset(Offset = "0x28")]
	public AudioClip victoryBgm;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004D1")]
	public AudioClip sfxClip;

	[Token(Token = "0x40004D2")]
	[FieldOffset(Offset = "0x38")]
	public PnlVictoryTypes[] pnlControls;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40004D3")]
	private PnlVictoryControls m_CurControls;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40004D4")]
	public List<Button> btnDownloadReports;

	[Token(Token = "0x6000560")]
	[Address(RVA = "0x567AF0", Offset = "0x5662F0", Length = "0x283")]
	private void InitEvent()
	{
	}

	[Address(RVA = "0x568720", Offset = "0x566F20", Length = "0x158")]
	[Token(Token = "0x6000561")]
	private void RefreshDownloadReportBtns()
	{
	}

	[Token(Token = "0x6000562")]
	[Address(RVA = "0x567E20", Offset = "0x566620", Length = "0x144")]
	private void OnDownloadBestReport()
	{
	}

	[Address(RVA = "0x567860", Offset = "0x566060", Length = "0x280")]
	[Token(Token = "0x6000563")]
	private void InitControl()
	{
	}

	[Token(Token = "0x6000564")]
	[Address(RVA = "0x568640", Offset = "0x566E40", Length = "0xD0")]
	public void PreWarm(int slice)
	{
	}

	[Address(RVA = "0x567D80", Offset = "0x566580", Length = "0x95")]
	[Token(Token = "0x6000565")]
	private void OnContinueClicked()
	{
	}

	[Token(Token = "0x6000566")]
	[Address(RVA = "0x567F70", Offset = "0x566770", Length = "0xBE")]
	private void OnResetClicked()
	{
	}

	[Token(Token = "0x6000567")]
	[Address(RVA = "0x568030", Offset = "0x566830", Length = "0xB6")]
	private void OnTglAdvJudgmentValueChanged(bool isOn, float normalizeTime = 0f)
	{
	}

	[Address(RVA = "0x569170", Offset = "0x567970", Length = "0x231")]
	[Token(Token = "0x6000568")]
	private void UpdateState()
	{
	}

	[Token(Token = "0x6000569")]
	[Address(RVA = "0x5680F0", Offset = "0x5668F0", Length = "0x545")]
	private void OnVictory(object sender, object rev, params object[] pars)
	{
	}

	[Address(RVA = "0x5675D0", Offset = "0x565DD0", Length = "0x217")]
	[Token(Token = "0x600056A")]
	private void CheckForceUpdateAction()
	{
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C300", Offset = "0x9B700")]
	[Token(Token = "0x600056B")]
	[Address(RVA = "0x5677F0", Offset = "0x565FF0", Length = "0x65")]
	private IEnumerator DelaySetRestartBtnInteractable()
	{
		return null;
	}

	[Token(Token = "0x600056C")]
	[Address(RVA = "0x568900", Offset = "0x567100", Length = "0x482")]
	private void SetDetailInfo()
	{
	}

	[Token(Token = "0x600056D")]
	[Address(RVA = "0x568D90", Offset = "0x567590", Length = "0x3CE")]
	private void SetScore()
	{
	}

	[Address(RVA = "0x568880", Offset = "0x567080", Length = "0x74")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C5A0", Offset = "0x9B9A0")]
	[Token(Token = "0x600056E")]
	private IEnumerator ScoreRoll(int targetScore)
	{
		return null;
	}

	[Address(RVA = "0x5693B0", Offset = "0x567BB0", Length = "0xE")]
	[Token(Token = "0x600056F")]
	public PnlVictory()
	{
	}
}
