using System;
using System.Collections.Generic;
using Assets.Scripts.UI.Abstracts;
using Cpp2ILInjected;
using MEC;
using PeroTools2.UI;
using UnityEngine;
using UnityEngine.UI;
using ZenFulcrum.EmbeddedBrowser;

namespace UI.PnlAccount;

[Token(Token = "0x20001BE")]
public class PopupPeroLoginV2 : BasePopup<AccountCanvas>
{
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000AE6")]
	[SerializeField]
	private InputField m_InputAccountStr;

	[SerializeField]
	[Token(Token = "0x4000AE7")]
	[FieldOffset(Offset = "0x110")]
	private InputField m_InputCode;

	[SerializeField]
	[Token(Token = "0x4000AE8")]
	[FieldOffset(Offset = "0x118")]
	private Button m_BtnSendCode;

	[SerializeField]
	[Token(Token = "0x4000AE9")]
	[FieldOffset(Offset = "0x120")]
	private Text m_TxtResendCodeTime;

	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Token(Token = "0x4000AEA")]
	private Button m_BtnPeroLogin;

	[Token(Token = "0x4000AEB")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	private GameObject m_MainLoginGroup;

	[Token(Token = "0x4000AEC")]
	[SerializeField]
	[FieldOffset(Offset = "0x138")]
	private GameObject m_OverseaLoginGroup;

	[SerializeField]
	[Token(Token = "0x4000AED")]
	[FieldOffset(Offset = "0x140")]
	private Button m_BtnXdLogin;

	[SerializeField]
	[Token(Token = "0x4000AEE")]
	[FieldOffset(Offset = "0x148")]
	private Button m_BtnGoogleLogin;

	[Token(Token = "0x4000AEF")]
	[SerializeField]
	[FieldOffset(Offset = "0x150")]
	private Button m_BtnAppleLogin;

	[SerializeField]
	[Token(Token = "0x4000AF0")]
	[FieldOffset(Offset = "0x158")]
	private Button m_BtnFacebookLogin;

	[SerializeField]
	[Token(Token = "0x4000AF1")]
	[FieldOffset(Offset = "0x160")]
	private Button m_BtnGoogleLoginOversea;

	[Token(Token = "0x4000AF2")]
	[FieldOffset(Offset = "0x168")]
	[SerializeField]
	private Button m_BtnAppleLoginOversea;

	[Token(Token = "0x4000AF3")]
	[SerializeField]
	[FieldOffset(Offset = "0x170")]
	private Button m_BtnFacebookLoginOversea;

	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4000AF4")]
	[SerializeField]
	private Button m_BtnOpenFeedback;

	[Token(Token = "0x4000AF5")]
	[FieldOffset(Offset = "0x180")]
	[SerializeField]
	private Toggle m_TglAgree;

	[Token(Token = "0x4000AF6")]
	[SerializeField]
	[FieldOffset(Offset = "0x188")]
	private ClickableText m_ClickTxtPrivacy;

	[Token(Token = "0x4000AF7")]
	[SerializeField]
	[FieldOffset(Offset = "0x190")]
	private Animator m_AnimaTglAgree;

	[SerializeField]
	[Token(Token = "0x4000AF8")]
	[FieldOffset(Offset = "0x198")]
	private Text m_TxtIosOverseaTip;

	[SerializeField]
	[Token(Token = "0x4000AF9")]
	[FieldOffset(Offset = "0x1A0")]
	private Browser m_LoginWebview;

	[Token(Token = "0x4000AFA")]
	[FieldOffset(Offset = "0x1A8")]
	private AccountCanvas m_PnlParent;

	[Token(Token = "0x4000AFB")]
	[FieldOffset(Offset = "0x1B0")]
	private AccountDataModel m_LoginDataModel;

	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000AFC")]
	private string m_PeroLoginType;

	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000AFD")]
	private CoroutineHandle m_SendCodeCooldownCount;

	[Token(Token = "0x6000C79")]
	[Address(RVA = "0x4DDD60", Offset = "0x4DC560", Length = "0x1F1")]
	protected override void RendDatasToUI()
	{
	}

	[Address(RVA = "0x4DD990", Offset = "0x4DC190", Length = "0x3CD")]
	[Token(Token = "0x6000C7A")]
	protected override void RegistClickEvts()
	{
	}

	[Address(RVA = "0x4DD8E0", Offset = "0x4DC0E0", Length = "0xAE")]
	[Token(Token = "0x6000C7B")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x4DE070", Offset = "0x4DC870", Length = "0x350")]
	[Token(Token = "0x6000C7C")]
	private void SetPanelElementsAccordingToPlatform()
	{
	}

	[Address(RVA = "0x4DE3E0", Offset = "0x4DCBE0", Length = "0x14F")]
	[Token(Token = "0x6000C7D")]
	private void SetPanelStates()
	{
	}

	[Token(Token = "0x6000C7E")]
	[Address(RVA = "0x4DD440", Offset = "0x4DBC40", Length = "0xF8")]
	private void OnClickToGoogleLogin()
	{
	}

	[Address(RVA = "0x4DD340", Offset = "0x4DBB40", Length = "0xF8")]
	[Token(Token = "0x6000C7F")]
	private void OnClickToFacebookLogin()
	{
	}

	[Token(Token = "0x6000C80")]
	[Address(RVA = "0x4DD860", Offset = "0x4DC060", Length = "0x74")]
	private void OnClickToXdLogin()
	{
	}

	[Address(RVA = "0x4DD540", Offset = "0x4DBD40", Length = "0x18B")]
	[Token(Token = "0x6000C81")]
	private void OnClickToPeroLogin()
	{
	}

	[Address(RVA = "0x4DD2C0", Offset = "0x4DBAC0", Length = "0x74")]
	[Token(Token = "0x6000C82")]
	private void OnClickToCNAppleLogin()
	{
	}

	[Token(Token = "0x6000C83")]
	[Address(RVA = "0x4DD220", Offset = "0x4DBA20", Length = "0x92")]
	private void OnClickToAppleLogin()
	{
	}

	[Token(Token = "0x6000C84")]
	[Address(RVA = "0x4DD6D0", Offset = "0x4DBED0", Length = "0x18A")]
	private void OnClickToSendCode()
	{
	}

	[Token(Token = "0x6000C85")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x502D0", Offset = "0x4F6D0")]
	[Address(RVA = "0x4DDFE0", Offset = "0x4DC7E0", Length = "0x81")]
	private IEnumerator<float> SendCodeCoroutine(string inputContent)
	{
		return null;
	}

	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x50500", Offset = "0x4F900")]
	[Token(Token = "0x6000C86")]
	[Address(RVA = "0x4DDF60", Offset = "0x4DC760", Length = "0x76")]
	private IEnumerator<float> SendCodeCooldownCoroutine(long remainTime)
	{
		return null;
	}

	[Token(Token = "0x6000C87")]
	[Address(RVA = "0x4DE530", Offset = "0x4DCD30", Length = "0x170")]
	private void ShowXdLoginTip(Action confirmCallback)
	{
	}

	[Token(Token = "0x6000C88")]
	[Address(RVA = "0x4DD1A0", Offset = "0x4DB9A0", Length = "0x72")]
	private bool GetIsAgree()
	{
		return default(bool);
	}

	[Address(RVA = "0x4DEB50", Offset = "0x4DD350", Length = "0x38")]
	[Token(Token = "0x6000C89")]
	public PopupPeroLoginV2()
	{
		((BasePopup<>)(object)this)._002Ector();
	}
}
