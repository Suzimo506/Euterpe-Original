using System;
using Account;
using Assets.Scripts.PeroTools.UI;
using Assets.Scripts.UI.Abstracts;
using Cpp2ILInjected;
using PeroTools2.UI;
using UnityEngine;
using UnityEngine.UI;
using ZenFulcrum.EmbeddedBrowser;

namespace UI.PnlAccount;

[Token(Token = "0x20001BD")]
public class PopupPeroLogin : BasePopup<AccountCanvas>
{
	[SerializeField]
	[Token(Token = "0x4000ACB")]
	[FieldOffset(Offset = "0x108")]
	private GameObject m_ChineseLoginGroup;

	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000ACC")]
	[SerializeField]
	private GameObject m_OverseaLoginGroup;

	[SerializeField]
	[Token(Token = "0x4000ACD")]
	[FieldOffset(Offset = "0x118")]
	private InputField m_InputPhoneNumber;

	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x4000ACE")]
	private Button m_BtnMobilePhoneLogin;

	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000ACF")]
	[SerializeField]
	private Button m_BtnThirdLogin;

	[SerializeField]
	[Token(Token = "0x4000AD0")]
	[FieldOffset(Offset = "0x130")]
	private Button m_BtnCNAppleLogin;

	[SerializeField]
	[Token(Token = "0x4000AD1")]
	[FieldOffset(Offset = "0x138")]
	private Button m_BtnAppleLogin;

	[SerializeField]
	[Token(Token = "0x4000AD2")]
	[FieldOffset(Offset = "0x140")]
	private Button m_BtnGoogleLogin;

	[SerializeField]
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000AD3")]
	private Button m_BtnFacebookLogin;

	[Token(Token = "0x4000AD4")]
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	private Browser m_LoginWebView;

	[SerializeField]
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000AD5")]
	private ClickableText m_AgreementTips;

	[Token(Token = "0x4000AD6")]
	[SerializeField]
	[FieldOffset(Offset = "0x160")]
	private Toggle m_Agreement;

	[SerializeField]
	[Token(Token = "0x4000AD7")]
	[FieldOffset(Offset = "0x168")]
	private Animator m_AgreementDisagreeAnim;

	[SerializeField]
	[Token(Token = "0x4000AD8")]
	[FieldOffset(Offset = "0x170")]
	private Button m_BtnQA;

	[SerializeField]
	[Token(Token = "0x4000AD9")]
	[FieldOffset(Offset = "0x178")]
	private GameObject m_BtnSteamChineseLoginSwitch;

	[SerializeField]
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4000ADA")]
	private GameObject m_BtnSteamOverseaLoginSwitch;

	[Token(Token = "0x4000ADB")]
	[FieldOffset(Offset = "0x188")]
	[SerializeField]
	private Toggle m_isSteamChineseLogin;

	[SerializeField]
	[Token(Token = "0x4000ADC")]
	[FieldOffset(Offset = "0x190")]
	private Popup m_PnlVerificationCode;

	[FieldOffset(Offset = "0x198")]
	[SerializeField]
	[Token(Token = "0x4000ADD")]
	private InputField m_VerificationInputField;

	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000ADE")]
	[SerializeField]
	private Text m_TxtVerificationTip;

	[SerializeField]
	[Token(Token = "0x4000ADF")]
	[FieldOffset(Offset = "0x1A8")]
	private Button m_BtnVerificationResend;

	[SerializeField]
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000AE0")]
	private Button m_BtnVerificationConfirm;

	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000AE1")]
	[SerializeField]
	private InputKeyBinding m_KeyBinding;

	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000AE2")]
	private bool isOversea;

	[Token(Token = "0x4000AE3")]
	[FieldOffset(Offset = "0x1C1")]
	private bool m_SteamIsOversea;

	[Token(Token = "0x4000AE4")]
	[FieldOffset(Offset = "0x1C8")]
	private string m_LastNumberOrEmail;

	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000AE5")]
	private bool m_VerifyCodeShowing;

	[Token(Token = "0x170000EC")]
	private AccountCanvas accountCanvas
	{
		[Address(RVA = "0x4E0A00", Offset = "0x4DF200", Length = "0x3E")]
		[Token(Token = "0x6000C5F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000ED")]
	private AccountPlatform loginPlatform
	{
		[Address(RVA = "0x4E0A40", Offset = "0x4DF240", Length = "0x5C")]
		[Token(Token = "0x6000C60")]
		get
		{
			return default(AccountPlatform);
		}
	}

	[Token(Token = "0x6000C61")]
	[Address(RVA = "0x4DF8B0", Offset = "0x4DE0B0", Length = "0x402")]
	protected override void RendDatasToUI()
	{
	}

	[Address(RVA = "0x4DF420", Offset = "0x4DDC20", Length = "0x482")]
	[Token(Token = "0x6000C62")]
	protected override void RegistClickEvts()
	{
	}

	[Token(Token = "0x6000C63")]
	[Address(RVA = "0x4E0840", Offset = "0x4DF040", Length = "0x151")]
	private void UnregistClickEvts()
	{
	}

	[Token(Token = "0x6000C64")]
	[Address(RVA = "0x4DF3B0", Offset = "0x4DDBB0", Length = "0x23")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000C65")]
	[Address(RVA = "0x4DF240", Offset = "0x4DDA40", Length = "0x168")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x4E00B0", Offset = "0x4DE8B0", Length = "0x2D5")]
	[Token(Token = "0x6000C66")]
	private void SubmitPhoneLogin()
	{
	}

	[Token(Token = "0x6000C67")]
	[Address(RVA = "0x4DEC90", Offset = "0x4DD490", Length = "0x74")]
	private void ChangeToThirdLogin()
	{
	}

	[Token(Token = "0x6000C68")]
	[Address(RVA = "0x4DFE50", Offset = "0x4DE650", Length = "0x1D1")]
	private void ShowXdsdkLoginSelections()
	{
	}

	[Address(RVA = "0x4DEC10", Offset = "0x4DD410", Length = "0x74")]
	[Token(Token = "0x6000C69")]
	private void CNAppleLogin()
	{
	}

	[Token(Token = "0x6000C6A")]
	[Address(RVA = "0x4DFD70", Offset = "0x4DE570", Length = "0xDA")]
	private void ShowTipToLogin(Action confirmCallback)
	{
	}

	[Token(Token = "0x6000C6B")]
	[Address(RVA = "0x4DEB90", Offset = "0x4DD390", Length = "0x7A")]
	private void AppleLogin()
	{
	}

	[Token(Token = "0x6000C6C")]
	[Address(RVA = "0x4DF070", Offset = "0x4DD870", Length = "0x1AC")]
	private void GoogleLogin()
	{
	}

	[Token(Token = "0x6000C6D")]
	[Address(RVA = "0x4DEE20", Offset = "0x4DD620", Length = "0x1AC")]
	private void FacebookLogin()
	{
	}

	[Token(Token = "0x6000C6E")]
	[Address(RVA = "0x4DF3E0", Offset = "0x4DDBE0", Length = "0x31")]
	private void QALinkDirect()
	{
	}

	[Token(Token = "0x6000C6F")]
	[Address(RVA = "0x4E0030", Offset = "0x4DE830", Length = "0x7F")]
	private void SteamSwitchLoginEnv(bool togIsOversea)
	{
	}

	[Token(Token = "0x6000C70")]
	[Address(RVA = "0x4DEFF0", Offset = "0x4DD7F0", Length = "0x72")]
	private bool GetIsAgree()
	{
		return default(bool);
	}

	[Address(RVA = "0x4DFCC0", Offset = "0x4DE4C0", Length = "0xA3")]
	[Token(Token = "0x6000C71")]
	private void ShowOverseaLoginOrNot(bool isOverseaActive)
	{
	}

	[Address(RVA = "0x4DED10", Offset = "0x4DD510", Length = "0x10C")]
	[Token(Token = "0x6000C72")]
	private static string ExtractNumbers(string input, int limit = 6)
	{
		return null;
	}

	[Token(Token = "0x6000C73")]
	[Address(RVA = "0x4E09A0", Offset = "0x4DF1A0", Length = "0x58")]
	public PopupPeroLogin()
	{
		((BasePopup<>)(object)this)._002Ector();
	}
}
