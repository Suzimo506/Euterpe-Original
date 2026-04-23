using Cpp2ILInjected;

[Token(Token = "0x20000C9")]
public class PnlNewPlayerPackageTips : BaseMessageBox
{
	[Token(Token = "0x60005BC")]
	[Address(RVA = "0x7B0B40", Offset = "0x7AF340", Length = "0x187")]
	public void Show(int discount)
	{
	}

	[Token(Token = "0x60005BD")]
	[Address(RVA = "0x7B0AE0", Offset = "0x7AF2E0", Length = "0x5B")]
	protected override void OnYesClicked()
	{
	}

	[Token(Token = "0x60005BE")]
	[Address(RVA = "0x7B0970", Offset = "0x7AF170", Length = "0x164")]
	private string GetMessageBoxText(int discount)
	{
		return null;
	}

	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	[Token(Token = "0x60005BF")]
	public PnlNewPlayerPackageTips()
	{
	}
}
