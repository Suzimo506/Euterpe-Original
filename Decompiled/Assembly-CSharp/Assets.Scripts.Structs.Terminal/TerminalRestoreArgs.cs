using Cpp2ILInjected;

namespace Assets.Scripts.Structs.Terminal;

[Token(Token = "0x2000592")]
public struct TerminalRestoreArgs
{
	[Token(Token = "0x40020C5")]
	[FieldOffset(Offset = "0x0")]
	public int code;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40020C6")]
	public string msg;

	[Token(Token = "0x40020C7")]
	[FieldOffset(Offset = "0x10")]
	public ExchangeItem[] data;
}
