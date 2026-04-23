using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlAccount;

[Token(Token = "0x200090D")]
public class PnlPhoneBindAsk : BaseMessageBox
{
	[Token(Token = "0x400309B")]
	[FieldOffset(Offset = "0xF0")]
	private PnlPhoneBind.InputType m_CurType;

	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400309C")]
	private string m_FinalSendTxt;

	[Token(Token = "0x400309D")]
	[SerializeField]
	[FieldOffset(Offset = "0x100")]
	private Text m_NickName;

	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x400309E")]
	private Text m_AccountLevel;

	[Token(Token = "0x400309F")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private Text m_IapPurchasedInfo;

	[Token(Token = "0x40030A0")]
	[SerializeField]
	[FieldOffset(Offset = "0x118")]
	private GameObject m_InfoArea;

	[Token(Token = "0x600522C")]
	[Address(RVA = "0x6CDFA0", Offset = "0x6CC7A0", Length = "0x18")]
	public void SetInputType(PnlPhoneBind.InputType inputType, string finalSendTxt)
	{
	}

	[Address(RVA = "0x6CDB60", Offset = "0x6CC360", Length = "0x100")]
	[Token(Token = "0x600522D")]
	public void GetExistAccountInfo()
	{
	}

	[Address(RVA = "0x6CDC70", Offset = "0x6CC470", Length = "0x301")]
	[Token(Token = "0x600522E")]
	private void OnReplaceClicked()
	{
	}

	[Token(Token = "0x600522F")]
	[Address(RVA = "0x6CDF80", Offset = "0x6CC780", Length = "0x1F")]
	protected override void OnYesClicked()
	{
	}

	[Token(Token = "0x6005230")]
	[Address(RVA = "0x4C6650", Offset = "0x4C4E50", Length = "0x2B")]
	protected override void OnNoClicked()
	{
	}

	[Token(Token = "0x6005231")]
	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	public PnlPhoneBindAsk()
	{
	}
}
