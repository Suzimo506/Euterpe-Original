using Cpp2ILInjected;

[Token(Token = "0x20000C8")]
public class PnlGotoShopAsk : BaseMessageBox
{
	[Token(Token = "0x60005BA")]
	[Address(RVA = "0x79F980", Offset = "0x79E180", Length = "0x59")]
	protected override void OnYesClicked()
	{
	}

	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	[Token(Token = "0x60005BB")]
	public PnlGotoShopAsk()
	{
	}
}
