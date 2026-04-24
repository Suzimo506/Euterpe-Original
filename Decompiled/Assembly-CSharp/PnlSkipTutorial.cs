using Cpp2ILInjected;

[Token(Token = "0x20000CC")]
public class PnlSkipTutorial : BaseMessageBox
{
	[Address(RVA = "0x5633D0", Offset = "0x561BD0", Length = "0x16")]
	[Token(Token = "0x60005C5")]
	protected override void OnYesClicked()
	{
	}

	[Token(Token = "0x60005C6")]
	[Address(RVA = "0x563300", Offset = "0x561B00", Length = "0xC5")]
	protected override void OnNoClicked()
	{
	}

	[Address(RVA = "0x5633F0", Offset = "0x561BF0", Length = "0x8F")]
	[Token(Token = "0x60005C7")]
	public override void Show()
	{
	}

	[Token(Token = "0x60005C8")]
	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	public PnlSkipTutorial()
	{
	}
}
