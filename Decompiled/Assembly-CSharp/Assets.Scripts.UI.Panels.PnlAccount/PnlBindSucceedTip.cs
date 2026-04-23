using Cpp2ILInjected;

namespace Assets.Scripts.UI.Panels.PnlAccount;

[Token(Token = "0x2000905")]
public class PnlBindSucceedTip : BaseMessageBox
{
	[Address(RVA = "0x6CBF20", Offset = "0x6CA720", Length = "0x6D")]
	[Token(Token = "0x6005202")]
	protected override void OnYesClicked()
	{
	}

	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	[Token(Token = "0x6005203")]
	public PnlBindSucceedTip()
	{
	}
}
