using System.Collections;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlAccount;

[Token(Token = "0x2000902")]
public class PnlAccountSystem : BaseMessageBox
{
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4003067")]
	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x71AF0", Offset = "0x70EF0")]
	private Text m_TxtNameValue;

	[Token(Token = "0x4003068")]
	[SerializeField]
	[FieldOffset(Offset = "0xF8")]
	private Text m_BindAccountTipTxt;

	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4003069")]
	[SerializeField]
	private Text m_AccountShowTxt;

	[Token(Token = "0x400306A")]
	[SerializeField]
	[FieldOffset(Offset = "0x108")]
	private Button m_BindChangeBtn;

	[SerializeField]
	[Token(Token = "0x400306B")]
	[FieldOffset(Offset = "0x110")]
	private Transform userInfoPos;

	[SerializeField]
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x400306C")]
	private Button m_LogoutButton;

	[Token(Token = "0x400306D")]
	[SerializeField]
	[FieldOffset(Offset = "0x120")]
	private Button m_ChangeIdButton;

	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Token(Token = "0x400306E")]
	private Button m_BindAccountButton;

	[SerializeField]
	[Token(Token = "0x400306F")]
	[FieldOffset(Offset = "0x130")]
	private Button m_OpenAccountDeleteButton;

	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4003070")]
	[SerializeField]
	private GameObject m_PnlAccountQaObj;

	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Token(Token = "0x4003071")]
	private GameObject m_TxtAgreementTMP;

	[SerializeField]
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4003072")]
	private RectTransform m_ImgAccountMobile;

	[SerializeField]
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4003073")]
	private Button m_BtnPeroRealName;

	[Address(RVA = "0x6C37F0", Offset = "0x6C1FF0", Length = "0x334")]
	[Token(Token = "0x60051E1")]
	public override void StartInit()
	{
	}

	[Address(RVA = "0x6C35D0", Offset = "0x6C1DD0", Length = "0x215")]
	[Token(Token = "0x60051E2")]
	public override void Show()
	{
	}

	[Token(Token = "0x60051E3")]
	[Address(RVA = "0x6C34D0", Offset = "0x6C1CD0", Length = "0x83")]
	private void PlayClickSfx()
	{
	}

	[Token(Token = "0x60051E4")]
	[Address(RVA = "0x4C6650", Offset = "0x4C4E50", Length = "0x2B")]
	protected override void OnNoClicked()
	{
	}

	[Token(Token = "0x60051E5")]
	[Address(RVA = "0x6C2B90", Offset = "0x6C1390", Length = "0x139")]
	private void CheckToShowRealNameEntry()
	{
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x72E00", Offset = "0x72200")]
	[Token(Token = "0x60051E6")]
	[Address(RVA = "0x6C3560", Offset = "0x6C1D60", Length = "0x65")]
	private IEnumerator PnlStateReset()
	{
		return null;
	}

	[Token(Token = "0x60051E7")]
	[Address(RVA = "0x6C2AB0", Offset = "0x6C12B0", Length = "0xD1")]
	private void ActiveState(bool unBind, bool bind)
	{
	}

	[Token(Token = "0x60051E8")]
	[Address(RVA = "0x6C3110", Offset = "0x6C1910", Length = "0xDE")]
	private void OnBindButtonClicked()
	{
	}

	[Address(RVA = "0x6C2CD0", Offset = "0x6C14D0", Length = "0x238")]
	[Token(Token = "0x60051E9")]
	private void GetBindInfo()
	{
	}

	[Address(RVA = "0x6C2F10", Offset = "0x6C1710", Length = "0xE7")]
	[Token(Token = "0x60051EA")]
	private string MaskAccountInfo(bool isEmail, string account)
	{
		return null;
	}

	[Token(Token = "0x60051EB")]
	[Address(RVA = "0x6C3320", Offset = "0x6C1B20", Length = "0xA4")]
	private void OnLogoutClicked()
	{
	}

	[Token(Token = "0x60051EC")]
	[Address(RVA = "0x6C31F0", Offset = "0x6C19F0", Length = "0xBC")]
	private void OnChangeIdClicked()
	{
	}

	[Token(Token = "0x60051ED")]
	[Address(RVA = "0x6C3090", Offset = "0x6C1890", Length = "0x75")]
	private void OnBindAccountButtonClicked()
	{
	}

	[Address(RVA = "0x6C3000", Offset = "0x6C1800", Length = "0x84")]
	[Token(Token = "0x60051EE")]
	private void OnAccountQAPanel()
	{
	}

	[Address(RVA = "0x6C32B0", Offset = "0x6C1AB0", Length = "0x68")]
	[Token(Token = "0x60051EF")]
	private void OnClickToPeroRealName()
	{
	}

	[Token(Token = "0x60051F0")]
	[Address(RVA = "0x6C33D0", Offset = "0x6C1BD0", Length = "0xFB")]
	private void OnShowAgreement(bool isShow)
	{
	}

	[Token(Token = "0x60051F1")]
	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	public PnlAccountSystem()
	{
	}
}
