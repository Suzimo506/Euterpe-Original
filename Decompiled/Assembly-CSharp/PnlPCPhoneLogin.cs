using System.Collections;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200018F")]
public class PnlPCPhoneLogin : MonoBehaviour
{
	[Token(Token = "0x2000A4A")]
	private enum InputType
	{
		[Token(Token = "0x4003696")]
		Phone,
		[Token(Token = "0x4003697")]
		Email
	}

	[Token(Token = "0x40009C4")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private InputField m_InputField_Phone;

	[SerializeField]
	[Token(Token = "0x40009C5")]
	[FieldOffset(Offset = "0x20")]
	private InputField m_InputField_Email;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009C6")]
	[SerializeField]
	private Button m_PhoneBtn;

	[Token(Token = "0x40009C7")]
	[SerializeField]
	[FieldOffset(Offset = "0x30")]
	private Button m_EmailBtn;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40009C8")]
	[SerializeField]
	private Button m_SendBtn;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40009C9")]
	[SerializeField]
	private GameObject m_PhoneLine;

	[SerializeField]
	[Token(Token = "0x40009CA")]
	[FieldOffset(Offset = "0x48")]
	private GameObject m_EmailLine;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40009CB")]
	private InputType m_CurType;

	[Token(Token = "0x40009CC")]
	[FieldOffset(Offset = "0x58")]
	private string m_FinalSendTxt;

	[Token(Token = "0x40009CD")]
	[SerializeField]
	[FieldOffset(Offset = "0x60")]
	private InputField m_CodeInputField;

	[SerializeField]
	[Token(Token = "0x40009CE")]
	[FieldOffset(Offset = "0x68")]
	private Button m_SendCodeBtn;

	[Token(Token = "0x40009CF")]
	[SerializeField]
	[FieldOffset(Offset = "0x70")]
	private Button m_ReSendBtn;

	[SerializeField]
	[Token(Token = "0x40009D0")]
	[FieldOffset(Offset = "0x78")]
	private Text m_TimeTxt;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40009D1")]
	private int m_ResendTimer;

	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x40009D2")]
	private bool m_BeginCountDown;

	[SerializeField]
	[Token(Token = "0x40009D3")]
	[FieldOffset(Offset = "0x88")]
	private Text m_PhoneTagTxt;

	[Token(Token = "0x40009D4")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Text m_EmailTagTxt;

	[Address(RVA = "0x7B0E30", Offset = "0x7AF630", Length = "0x27A")]
	[Token(Token = "0x6000B4B")]
	private void Start()
	{
	}

	[Token(Token = "0x6000B4C")]
	[Address(RVA = "0x7B0DC0", Offset = "0x7AF5C0", Length = "0x65")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x41540", Offset = "0x40940")]
	private IEnumerator ResendCountDown()
	{
		return null;
	}

	[Token(Token = "0x6000B4D")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlPCPhoneLogin()
	{
	}
}
