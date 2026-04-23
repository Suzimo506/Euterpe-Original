using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000CA")]
public class PnlOfficialWebsiteAsk : BaseMessageBox
{
	[Token(Token = "0x4000504")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private string m_Url;

	[Token(Token = "0x60005C0")]
	[Address(RVA = "0x7B0CD0", Offset = "0x7AF4D0", Length = "0x23")]
	protected override void OnYesClicked()
	{
	}

	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	[Token(Token = "0x60005C1")]
	public PnlOfficialWebsiteAsk()
	{
	}
}
