using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlAccount;

[Token(Token = "0x200090E")]
public class PnlPhoneBindChangeAsk : BaseMessageBox
{
	[SerializeField]
	[Token(Token = "0x40030A1")]
	[FieldOffset(Offset = "0xF0")]
	private Button m_BindExplainBtn;

	[Token(Token = "0x40030A2")]
	[FieldOffset(Offset = "0xF8")]
	private string m_AccountNumber;

	[Address(RVA = "0x6CE330", Offset = "0x6CCB30", Length = "0x8C")]
	[Token(Token = "0x6005234")]
	public override void StartInit()
	{
	}

	[Address(RVA = "0x6CE320", Offset = "0x6CCB20", Length = "0xF")]
	[Token(Token = "0x6005235")]
	public void SetAccountNumber(string number)
	{
	}

	[Address(RVA = "0x4C6650", Offset = "0x4C4E50", Length = "0x2B")]
	[Token(Token = "0x6005236")]
	protected override void OnNoClicked()
	{
	}

	[Token(Token = "0x6005237")]
	[Address(RVA = "0x6CE210", Offset = "0x6CCA10", Length = "0xC8")]
	protected override void OnYesClicked()
	{
	}

	[Address(RVA = "0x6CE2E0", Offset = "0x6CCAE0", Length = "0x31")]
	[Token(Token = "0x6005238")]
	private void OpenPersonBindUrl()
	{
	}

	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	[Token(Token = "0x6005239")]
	public PnlPhoneBindChangeAsk()
	{
	}
}
