using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000381")]
public class AsyncRenameStreamFileResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40014BC")]
	public string old_filename;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40014BD")]
	public string new_filename;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002EEC")]
	public AsyncRenameStreamFileResult()
	{
	}
}
