using Assets.Scripts.UI.GameMain;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace DaveGameFramework.GameComponents.GameHUD;

[Token(Token = "0x20004D2")]
public class PnlGameStateHud : MonoBehaviour
{
	[Token(Token = "0x4001A43")]
	[FieldOffset(Offset = "0x18")]
	private int m_CurrentCombo;

	[Token(Token = "0x4001A44")]
	[FieldOffset(Offset = "0x1C")]
	private int m_CurrentScore;

	[Token(Token = "0x4001A45")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CountAnimator m_CountAnimator;

	[SerializeField]
	[Token(Token = "0x4001A46")]
	[FieldOffset(Offset = "0x28")]
	private Text m_TxtScore;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001A47")]
	[SerializeField]
	private Slider m_SldProgress;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001A48")]
	private DaveGameManager m_DaveGameManager;

	[Token(Token = "0x60035E6")]
	[Address(RVA = "0x9A2B60", Offset = "0x9A1360", Length = "0x5B")]
	public void Init()
	{
	}

	[Token(Token = "0x60035E7")]
	[Address(RVA = "0x9A2BF0", Offset = "0x9A13F0", Length = "0xA7")]
	public void UpdateHudData()
	{
	}

	[Address(RVA = "0x9A2AD0", Offset = "0x9A12D0", Length = "0x84")]
	[Token(Token = "0x60035E8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60035E9")]
	[Address(RVA = "0x9A2BC0", Offset = "0x9A13C0", Length = "0x20")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60035EA")]
	public PnlGameStateHud()
	{
	}
}
