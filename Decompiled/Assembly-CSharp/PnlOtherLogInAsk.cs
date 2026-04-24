using Cpp2ILInjected;

[Token(Token = "0x200013E")]
public class PnlOtherLogInAsk : BaseMessageBox
{
	[Address(RVA = "0x7B0D60", Offset = "0x7AF560", Length = "0x58")]
	[Token(Token = "0x60008FB")]
	protected override void OnYesClicked()
	{
	}

	[Token(Token = "0x60008FC")]
	[Address(RVA = "0x7B0D00", Offset = "0x7AF500", Length = "0x58")]
	protected override void OnNoClicked()
	{
	}

	[Token(Token = "0x60008FD")]
	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	public PnlOtherLogInAsk()
	{
	}
}
