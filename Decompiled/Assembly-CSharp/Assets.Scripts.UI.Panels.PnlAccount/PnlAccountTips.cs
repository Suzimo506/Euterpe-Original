using Cpp2ILInjected;

namespace Assets.Scripts.UI.Panels.PnlAccount;

[Token(Token = "0x2000903")]
public class PnlAccountTips : BaseMessageBox
{
	[Address(RVA = "0x6C3C90", Offset = "0x6C2490", Length = "0x58")]
	[Token(Token = "0x60051F3")]
	protected override void OnYesClicked()
	{
	}

	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	[Token(Token = "0x60051F4")]
	public PnlAccountTips()
	{
	}
}
