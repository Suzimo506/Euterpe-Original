using System.Collections;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlAccount;

[Token(Token = "0x2000904")]
public class PnlAccountVerify : BaseMessageBox
{
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4003074")]
	private int m_ResendTimer;

	[Token(Token = "0x4003075")]
	[FieldOffset(Offset = "0xF4")]
	private bool m_BeginCountDown;

	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x4003076")]
	private InputField m_CodeInputField;

	[Token(Token = "0x4003077")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private Button m_ReSendBtn;

	[SerializeField]
	[Token(Token = "0x4003078")]
	[FieldOffset(Offset = "0x108")]
	private Text m_TimeTxt;

	[Token(Token = "0x4003079")]
	[FieldOffset(Offset = "0x110")]
	private Coroutine m_CountDown;

	[Token(Token = "0x400307A")]
	[FieldOffset(Offset = "0x118")]
	private PnlPhoneBind.InputType m_InputType;

	[Token(Token = "0x400307B")]
	[FieldOffset(Offset = "0x120")]
	private string m_FinalSendText;

	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x400307C")]
	private PnlPMDPhoneLoginState.BindType m_BindType;

	[Token(Token = "0x170008B6")]
	public bool beginCountDown
	{
		[Address(RVA = "0x6C4A90", Offset = "0x6C3290", Length = "0x8")]
		[Token(Token = "0x60051F5")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x6C3CF0", Offset = "0x6C24F0", Length = "0x53")]
	[Token(Token = "0x60051F6")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60051F7")]
	[Address(RVA = "0x6C45D0", Offset = "0x6C2DD0", Length = "0x8C")]
	public override void StartInit()
	{
	}

	[Address(RVA = "0x4C6650", Offset = "0x4C4E50", Length = "0x2B")]
	[Token(Token = "0x60051F8")]
	protected override void OnNoClicked()
	{
	}

	[Address(RVA = "0x6C3FB0", Offset = "0x6C27B0", Length = "0x1F")]
	[Token(Token = "0x60051F9")]
	protected override void OnYesClicked()
	{
	}

	[Address(RVA = "0x6C4040", Offset = "0x6C2840", Length = "0x360")]
	[Token(Token = "0x60051FA")]
	private void SendVerifyCode()
	{
	}

	[Address(RVA = "0x6C3D50", Offset = "0x6C2550", Length = "0x256")]
	[Token(Token = "0x60051FB")]
	private void OnResendClicked()
	{
	}

	[Token(Token = "0x60051FC")]
	[Address(RVA = "0x6C43B0", Offset = "0x6C2BB0", Length = "0x42")]
	public void SetSendType(PnlPhoneBind.InputType inputType, string finalSendText, PnlPMDPhoneLoginState.BindType bindType)
	{
	}

	[Token(Token = "0x60051FD")]
	[Address(RVA = "0x6C4400", Offset = "0x6C2C00", Length = "0x1CC")]
	private void StartCountDown()
	{
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x74600", Offset = "0x73A00")]
	[Token(Token = "0x60051FE")]
	[Address(RVA = "0x6C3FD0", Offset = "0x6C27D0", Length = "0x65")]
	private IEnumerator ResendCountDown()
	{
		return null;
	}

	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	[Token(Token = "0x60051FF")]
	public PnlAccountVerify()
	{
	}
}
