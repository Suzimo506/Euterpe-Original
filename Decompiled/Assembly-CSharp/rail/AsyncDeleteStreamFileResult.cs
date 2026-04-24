using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200037C")]
public class AsyncDeleteStreamFileResult : EventBase
{
	[Token(Token = "0x40014AD")]
	[FieldOffset(Offset = "0x30")]
	public string filename;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002EE7")]
	public AsyncDeleteStreamFileResult()
	{
	}
}
