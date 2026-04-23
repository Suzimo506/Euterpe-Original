using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.PnlAccount;

[Token(Token = "0x2000907")]
public class PnlBindTipsCancelAsk : BaseMessageBox
{
	[SerializeField]
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4003080")]
	private GameObject m_TapTapTip;

	[SerializeField]
	[Token(Token = "0x4003081")]
	[FieldOffset(Offset = "0xF8")]
	private GameObject m_SteamTip;

	[SerializeField]
	[Token(Token = "0x4003082")]
	[FieldOffset(Offset = "0x100")]
	private GameObject m_IOSTip;

	[Token(Token = "0x6005209")]
	[Address(RVA = "0x6CC120", Offset = "0x6CA920", Length = "0x72")]
	public override void Show()
	{
	}

	[Token(Token = "0x600520A")]
	[Address(RVA = "0x6CC0B0", Offset = "0x6CA8B0", Length = "0x6B")]
	private void SetTips()
	{
	}

	[Address(RVA = "0x6CC230", Offset = "0x6CAA30", Length = "0x8A")]
	[Token(Token = "0x600520B")]
	protected override void OnYesClicked()
	{
	}

	[Address(RVA = "0x6CC1A0", Offset = "0x6CA9A0", Length = "0x82")]
	[Token(Token = "0x600520C")]
	protected override void OnNoClicked()
	{
	}

	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	[Token(Token = "0x600520D")]
	public PnlBindTipsCancelAsk()
	{
	}
}
