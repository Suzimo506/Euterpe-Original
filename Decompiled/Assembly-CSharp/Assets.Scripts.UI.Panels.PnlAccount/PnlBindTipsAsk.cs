using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.PnlAccount;

[Token(Token = "0x2000906")]
public class PnlBindTipsAsk : BaseMessageBox
{
	[SerializeField]
	[Token(Token = "0x400307D")]
	[FieldOffset(Offset = "0xF0")]
	private GameObject m_TapTapTip;

	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400307E")]
	[SerializeField]
	private GameObject m_SteamTip;

	[SerializeField]
	[Token(Token = "0x400307F")]
	[FieldOffset(Offset = "0x100")]
	private GameObject m_IOSTip;

	[Address(RVA = "0x6CC120", Offset = "0x6CA920", Length = "0x72")]
	[Token(Token = "0x6005204")]
	public override void Show()
	{
	}

	[Address(RVA = "0x6CC0B0", Offset = "0x6CA8B0", Length = "0x6B")]
	[Token(Token = "0x6005205")]
	private void SetTips()
	{
	}

	[Token(Token = "0x6005206")]
	[Address(RVA = "0x6CC020", Offset = "0x6CA820", Length = "0x8A")]
	protected override void OnYesClicked()
	{
	}

	[Token(Token = "0x6005207")]
	[Address(RVA = "0x6CBF90", Offset = "0x6CA790", Length = "0x8A")]
	protected override void OnNoClicked()
	{
	}

	[Token(Token = "0x6005208")]
	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	public PnlBindTipsAsk()
	{
	}
}
