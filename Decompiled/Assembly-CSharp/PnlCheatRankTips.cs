using Cpp2ILInjected;
using PeroTools2.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000C3")]
public class PnlCheatRankTips : BaseMessageBox
{
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40004FD")]
	[SerializeField]
	private TextMeshProUGUI m_TxtCheatTips;

	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40004FE")]
	[SerializeField]
	private ClickableText m_ClickText;

	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x40004FF")]
	private Button m_BtnConfirm;

	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000500")]
	[SerializeField]
	private Button m_BtnCopyEmail;

	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000501")]
	private bool m_IsDeviceCheat;

	[FieldOffset(Offset = "0x111")]
	[Token(Token = "0x4000502")]
	private bool m_IsThirdPartyCheat;

	[FieldOffset(Offset = "0x112")]
	[Token(Token = "0x4000503")]
	private bool m_IsAccountCheat;

	[Address(RVA = "0x4FCB90", Offset = "0x4FB390", Length = "0x166")]
	[Token(Token = "0x60005A8")]
	private void Awake()
	{
	}

	[Address(RVA = "0x4FCF20", Offset = "0x4FB720", Length = "0xCB")]
	[Token(Token = "0x60005A9")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x4FCD00", Offset = "0x4FB500", Length = "0x1A2")]
	public void CheckAndShow(bool isDeviceCheat, bool isThirdPartyCheat, bool isAccountCheat, string function)
	{
	}

	[Address(RVA = "0x4FD090", Offset = "0x4FB890", Length = "0x179")]
	[Token(Token = "0x60005AB")]
	private void OnlyShow(string function)
	{
	}

	[Token(Token = "0x60005AC")]
	[Address(RVA = "0x4FCEB0", Offset = "0x4FB6B0", Length = "0x60")]
	private void CopyEmail()
	{
	}

	[Address(RVA = "0x4FD060", Offset = "0x4FB860", Length = "0x2B")]
	[Token(Token = "0x60005AD")]
	protected override void OnYesClicked()
	{
	}

	[Address(RVA = "0x4FCFF0", Offset = "0x4FB7F0", Length = "0x68")]
	[Token(Token = "0x60005AE")]
	private void OnLinkTxtClick(string linkId, string linkInfo)
	{
	}

	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	[Token(Token = "0x60005AF")]
	public PnlCheatRankTips()
	{
	}
}
