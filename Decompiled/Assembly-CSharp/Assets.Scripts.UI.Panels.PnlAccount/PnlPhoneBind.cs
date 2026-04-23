using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlAccount;

[Token(Token = "0x200090C")]
public class PnlPhoneBind : BaseMessageBox
{
	[Token(Token = "0x2000D96")]
	public enum InputType
	{
		[Token(Token = "0x4004035")]
		Phone,
		[Token(Token = "0x4004036")]
		Email
	}

	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4003091")]
	[SerializeField]
	private Button m_PhoneBtn;

	[Token(Token = "0x4003092")]
	[SerializeField]
	[FieldOffset(Offset = "0xF8")]
	private Button m_EmailBtn;

	[SerializeField]
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4003093")]
	private Text m_PhoneTagTxt;

	[Token(Token = "0x4003094")]
	[SerializeField]
	[FieldOffset(Offset = "0x108")]
	private Text m_EmailTagTxt;

	[SerializeField]
	[Token(Token = "0x4003095")]
	[FieldOffset(Offset = "0x110")]
	private InputField m_InputField_Phone;

	[SerializeField]
	[Token(Token = "0x4003096")]
	[FieldOffset(Offset = "0x118")]
	private InputField m_InputField_Email;

	[SerializeField]
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4003097")]
	private GameObject m_PhoneLine;

	[SerializeField]
	[Token(Token = "0x4003098")]
	[FieldOffset(Offset = "0x128")]
	private GameObject m_EmailLine;

	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4003099")]
	private InputType m_CurType;

	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x400309A")]
	private string m_FinalSendTxt;

	[Address(RVA = "0x6CEB10", Offset = "0x6CD310", Length = "0xE4")]
	[Token(Token = "0x6005223")]
	public override void StartInit()
	{
	}

	[Token(Token = "0x6005224")]
	[Address(RVA = "0x6CE6E0", Offset = "0x6CCEE0", Length = "0x46")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6005225")]
	[Address(RVA = "0x6CE670", Offset = "0x6CCE70", Length = "0x43")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6005226")]
	[Address(RVA = "0x6CE730", Offset = "0x6CCF30", Length = "0x11")]
	private void OnPhoneClicked()
	{
	}

	[Token(Token = "0x6005227")]
	[Address(RVA = "0x6CE6C0", Offset = "0x6CCEC0", Length = "0x11")]
	private void OnEmailClicked()
	{
	}

	[Token(Token = "0x6005228")]
	[Address(RVA = "0x4C6650", Offset = "0x4C4E50", Length = "0x2B")]
	protected override void OnNoClicked()
	{
	}

	[Address(RVA = "0x6CE750", Offset = "0x6CCF50", Length = "0x3BA")]
	[Token(Token = "0x6005229")]
	protected override void OnYesClicked()
	{
	}

	[Address(RVA = "0x6CE3C0", Offset = "0x6CCBC0", Length = "0x2AB")]
	[Token(Token = "0x600522A")]
	private void BindInit()
	{
	}

	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	[Token(Token = "0x600522B")]
	public PnlPhoneBind()
	{
	}
}
