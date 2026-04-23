using Cpp2ILInjected;

[Token(Token = "0x20000F4")]
public class PnlAccountDelete : BaseMessageBox
{
	[Token(Token = "0x600072F")]
	[Address(RVA = "0x4FA500", Offset = "0x4F8D00", Length = "0x75")]
	protected override void OnYesClicked()
	{
	}

	[Token(Token = "0x6000730")]
	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	public PnlAccountDelete()
	{
	}
}
