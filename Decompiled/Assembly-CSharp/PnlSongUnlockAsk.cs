using Cpp2ILInjected;

[Token(Token = "0x20000CD")]
public class PnlSongUnlockAsk : BaseMessageBox
{
	[Token(Token = "0x60005C9")]
	[Address(RVA = "0x563480", Offset = "0x561C80", Length = "0x78")]
	protected override void OnYesClicked()
	{
	}

	[Token(Token = "0x60005CA")]
	[Address(RVA = "0x563500", Offset = "0x561D00", Length = "0x71")]
	private void SwitchToDlc()
	{
	}

	[Token(Token = "0x60005CB")]
	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	public PnlSongUnlockAsk()
	{
	}
}
