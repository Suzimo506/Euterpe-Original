using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000932")]
public class OpenDlc : MonoBehaviour
{
	[Token(Token = "0x400317F")]
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	private Button m_Button;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4003180")]
	[SerializeField]
	private Animator m_PnlStageAnimator;

	[SerializeField]
	[Token(Token = "0x4003181")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_PnlDlc;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4003182")]
	[SerializeField]
	private Button m_BtnBanTips;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4003183")]
	private bool isDeviceCheat;

	[Token(Token = "0x4003184")]
	[FieldOffset(Offset = "0x39")]
	private bool isThirdPartyCheat;

	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x4003185")]
	private bool isAccountCheat;

	[Token(Token = "0x6005332")]
	[Address(RVA = "0x42F870", Offset = "0x42E070", Length = "0xD5")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005333")]
	[Address(RVA = "0x42FC90", Offset = "0x42E490", Length = "0x194")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x42FAC0", Offset = "0x42E2C0", Length = "0x1CF")]
	[Token(Token = "0x6005334")]
	private void OnButtonClicked()
	{
	}

	[Token(Token = "0x6005335")]
	[Address(RVA = "0x42FE30", Offset = "0x42E630", Length = "0x90")]
	private void OpenShop()
	{
	}

	[Address(RVA = "0x42F950", Offset = "0x42E150", Length = "0x16C")]
	[Token(Token = "0x6005336")]
	private void OnBtnPurchaseBanClicked()
	{
	}

	[Token(Token = "0x6005337")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public OpenDlc()
	{
	}
}
