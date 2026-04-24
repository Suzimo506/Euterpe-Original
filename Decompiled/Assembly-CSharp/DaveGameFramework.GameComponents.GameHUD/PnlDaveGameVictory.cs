using Cpp2ILInjected;
using DaveGameFramework.GameInstanceData;
using UnityEngine;
using UnityEngine.UI;

namespace DaveGameFramework.GameComponents.GameHUD;

[Token(Token = "0x20004D0")]
public class PnlDaveGameVictory : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001A2C")]
	[SerializeField]
	private PnlDaveGameVictoryChild[] m_PnlChildren;

	[SerializeField]
	[Token(Token = "0x4001A2D")]
	[FieldOffset(Offset = "0x20")]
	private AudioClip m_BgmVictroy;

	[SerializeField]
	[Token(Token = "0x4001A2E")]
	[FieldOffset(Offset = "0x28")]
	private AudioClip m_SfxClicked;

	[Token(Token = "0x4001A2F")]
	[SerializeField]
	[FieldOffset(Offset = "0x30")]
	private Button m_BtnCreateReport;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001A30")]
	private float m_SfxVolume;

	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001A31")]
	private float m_BgmVolume;

	[Token(Token = "0x4001A32")]
	[FieldOffset(Offset = "0x40")]
	private DaveGameManager m_DaveGameManager;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001A33")]
	private DaveGameResultData m_DaveGameResultData;

	[Address(RVA = "0x9A21D0", Offset = "0x9A09D0", Length = "0x293")]
	[Token(Token = "0x60035DA")]
	public void Init()
	{
	}

	[Token(Token = "0x60035DB")]
	[Address(RVA = "0x9A29A0", Offset = "0x9A11A0", Length = "0x125")]
	public void Show()
	{
	}

	[Address(RVA = "0x9A2160", Offset = "0x9A0960", Length = "0x65")]
	[Token(Token = "0x60035DC")]
	public void Hide()
	{
	}

	[Token(Token = "0x60035DD")]
	[Address(RVA = "0x9A2470", Offset = "0x9A0C70", Length = "0x5D")]
	public void PlayClickSound()
	{
	}

	[Address(RVA = "0x9A1F80", Offset = "0x9A0780", Length = "0x1DB")]
	[Token(Token = "0x60035DE")]
	private void CreateResultCard()
	{
	}

	[Address(RVA = "0x9A24D0", Offset = "0x9A0CD0", Length = "0x4C9")]
	[Token(Token = "0x60035DF")]
	private void RecordResult(DaveGameResultData resData)
	{
	}

	[Token(Token = "0x60035E0")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlDaveGameVictory()
	{
	}
}
