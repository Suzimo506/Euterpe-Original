using Cpp2ILInjected;

namespace UI.PnlAccount;

[Token(Token = "0x20001BC")]
public struct LoginBoardStates
{
	[Token(Token = "0x4000AC9")]
	[FieldOffset(Offset = "0x0")]
	public bool useNewBoard;

	[Token(Token = "0x4000ACA")]
	[FieldOffset(Offset = "0x1")]
	public bool usePeroSdk;
}
