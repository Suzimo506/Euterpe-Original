using Cpp2ILInjected;

namespace Assets.Scripts.UI.Panels.PnlAccount;

[Token(Token = "0x200090B")]
public class PnlLogOutAsk : BaseMessageBox
{
	[Token(Token = "0x6005220")]
	[Address(RVA = "0x4C6650", Offset = "0x4C4E50", Length = "0x2B")]
	protected override void OnNoClicked()
	{
	}

	[Token(Token = "0x6005221")]
	[Address(RVA = "0x6CD3A0", Offset = "0x6CBBA0", Length = "0x6C")]
	protected override void OnYesClicked()
	{
	}

	[Token(Token = "0x6005222")]
	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	public PnlLogOutAsk()
	{
	}
}
