using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using DaveGameFramework.GameInstanceData;
using UnityEngine;
using UnityEngine.UI;

namespace DaveGameFramework.GameComponents.GameHUD;

[Token(Token = "0x20004D1")]
public class PnlDaveGameVictoryChild : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4001A34")]
	[FieldOffset(Offset = "0x18")]
	private Button m_BtnRestart;

	[SerializeField]
	[Token(Token = "0x4001A35")]
	[FieldOffset(Offset = "0x20")]
	private Button m_BtnExit;

	[Token(Token = "0x4001A36")]
	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	private Text m_TxtSongTitle;

	[SerializeField]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001A37")]
	private Text m_TxtScore;

	[SerializeField]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001A38")]
	private Text m_TxtAccrancy;

	[Token(Token = "0x4001A39")]
	[SerializeField]
	[FieldOffset(Offset = "0x40")]
	private Text m_TxtMaxCombo;

	[SerializeField]
	[Token(Token = "0x4001A3A")]
	[FieldOffset(Offset = "0x48")]
	private Text m_TxtHitCount;

	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4001A3B")]
	private Text m_TxtMissCount;

	[SerializeField]
	[Token(Token = "0x4001A3C")]
	[FieldOffset(Offset = "0x58")]
	private Text m_TxtDifficulty;

	[Token(Token = "0x4001A3D")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Text m_TxtHighestScore;

	[Token(Token = "0x4001A3E")]
	[SerializeField]
	[FieldOffset(Offset = "0x68")]
	private GameMainGrade m_GradeShow;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001A3F")]
	private PnlDaveGameVictory m_PnlParent;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001A40")]
	private DaveGameManager m_GameManager;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001A41")]
	private DaveGameResultData m_ResultData;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001A42")]
	private List<IData> m_HighestRecords;

	[Token(Token = "0x60035E1")]
	[Address(RVA = "0x9A1800", Offset = "0x9A0000", Length = "0x15C")]
	public void Init(PnlDaveGameVictory parent)
	{
	}

	[Token(Token = "0x60035E2")]
	[Address(RVA = "0x9A1AE0", Offset = "0x9A02E0", Length = "0x494")]
	public void SetGameData(DaveGameResultData resData)
	{
	}

	[Token(Token = "0x60035E3")]
	[Address(RVA = "0x9A19F0", Offset = "0x9A01F0", Length = "0xEA")]
	private void OnBtnRestart()
	{
	}

	[Address(RVA = "0x9A1960", Offset = "0x9A0160", Length = "0x87")]
	[Token(Token = "0x60035E4")]
	private void OnBtnExit()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60035E5")]
	public PnlDaveGameVictoryChild()
	{
	}
}
