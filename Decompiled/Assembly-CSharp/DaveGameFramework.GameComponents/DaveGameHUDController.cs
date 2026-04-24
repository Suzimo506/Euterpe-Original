using Cpp2ILInjected;
using DaveGameFramework.GameComponents.GameHUD;
using UnityEngine;
using UnityEngine.UI;

namespace DaveGameFramework.GameComponents;

[Token(Token = "0x20004C1")]
public class DaveGameHUDController : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40019E6")]
	[SerializeField]
	private Button m_BtnPause;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40019E7")]
	[SerializeField]
	private Animator m_ReadyGoAnima;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40019E8")]
	[SerializeField]
	private PnlDaveGamePause m_PnlDaveGamePause;

	[SerializeField]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40019E9")]
	private PnlDaveGameFailed m_PnlDaveGameFailed;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40019EA")]
	[SerializeField]
	private PnlDaveGameVictory m_PnlDaveGameVictory;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40019EB")]
	[SerializeField]
	private PnlGameStateHud m_PnlGameStateHud;

	[Token(Token = "0x6003578")]
	[Address(RVA = "0x997570", Offset = "0x995D70", Length = "0x1CE")]
	public void Init()
	{
	}

	[Token(Token = "0x6003579")]
	[Address(RVA = "0x997C40", Offset = "0x996440", Length = "0xB0")]
	public void RefreshGameStateView()
	{
	}

	[Token(Token = "0x600357A")]
	[Address(RVA = "0x997EF0", Offset = "0x9966F0", Length = "0x75")]
	public void ShowReadyState()
	{
	}

	[Address(RVA = "0x997D90", Offset = "0x996590", Length = "0x15C")]
	[Token(Token = "0x600357B")]
	public void ShowGameVictory()
	{
	}

	[Address(RVA = "0x997D40", Offset = "0x996540", Length = "0x45")]
	[Token(Token = "0x600357C")]
	public void ShowGameFail()
	{
	}

	[Address(RVA = "0x997D00", Offset = "0x996500", Length = "0x3F")]
	[Token(Token = "0x600357D")]
	public void Reset()
	{
	}

	[Token(Token = "0x600357E")]
	[Address(RVA = "0x9977E0", Offset = "0x995FE0", Length = "0x1F7")]
	private void OnGameResume()
	{
	}

	[Token(Token = "0x600357F")]
	[Address(RVA = "0x9979E0", Offset = "0x9961E0", Length = "0x255")]
	private void PauseGame()
	{
	}

	[Token(Token = "0x6003580")]
	[Address(RVA = "0x997740", Offset = "0x995F40", Length = "0x9D")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6003581")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public DaveGameHUDController()
	{
	}
}
