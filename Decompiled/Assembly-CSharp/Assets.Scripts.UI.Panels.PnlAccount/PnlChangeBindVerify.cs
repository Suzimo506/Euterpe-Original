using System.Collections;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlAccount;

[Token(Token = "0x2000908")]
public class PnlChangeBindVerify : BaseMessageBox
{
	[SerializeField]
	[Token(Token = "0x4003083")]
	[FieldOffset(Offset = "0xF0")]
	private InputField m_CodeInputField;

	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4003084")]
	[SerializeField]
	private Button m_ResendBtn;

	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4003085")]
	[SerializeField]
	private Text m_TimeTxt;

	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4003086")]
	private int m_ResendTimer;

	[FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x4003087")]
	private bool m_BeginCountDown;

	[Token(Token = "0x4003088")]
	[FieldOffset(Offset = "0x110")]
	private WaitForSeconds m_WaitForSeconds;

	[Token(Token = "0x4003089")]
	[FieldOffset(Offset = "0x118")]
	private Coroutine m_CountDown;

	[Token(Token = "0x600520E")]
	[Address(RVA = "0x6CC9A0", Offset = "0x6CB1A0", Length = "0x149")]
	public override void StartInit()
	{
	}

	[Token(Token = "0x600520F")]
	[Address(RVA = "0x6CC930", Offset = "0x6CB130", Length = "0x69")]
	public override void Show()
	{
	}

	[Address(RVA = "0x6CC5C0", Offset = "0x6CADC0", Length = "0x2B")]
	[Token(Token = "0x6005210")]
	protected override void OnNoClicked()
	{
	}

	[Token(Token = "0x6005211")]
	[Address(RVA = "0x6CC830", Offset = "0x6CB030", Length = "0x1F")]
	protected override void OnYesClicked()
	{
	}

	[Token(Token = "0x6005212")]
	[Address(RVA = "0x6CC560", Offset = "0x6CAD60", Length = "0x53")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6005213")]
	[Address(RVA = "0x6CC2C0", Offset = "0x6CAAC0", Length = "0x29A")]
	private void OnConfirmClicked()
	{
	}

	[Address(RVA = "0x6CC5F0", Offset = "0x6CADF0", Length = "0x236")]
	[Token(Token = "0x6005214")]
	private void OnResendClicked()
	{
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x79660", Offset = "0x78A60")]
	[Token(Token = "0x6005215")]
	[Address(RVA = "0x6CC850", Offset = "0x6CB050", Length = "0x65")]
	private IEnumerator ResendCountDown()
	{
		return null;
	}

	[Token(Token = "0x6005216")]
	[Address(RVA = "0x6CC8C0", Offset = "0x6CB0C0", Length = "0x65")]
	private void ResetResendButton()
	{
	}

	[Address(RVA = "0x6CCEA0", Offset = "0x6CB6A0", Length = "0x70")]
	[Token(Token = "0x6005217")]
	public PnlChangeBindVerify()
	{
	}
}
