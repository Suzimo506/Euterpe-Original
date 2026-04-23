using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000394")]
public class RailTextInputResult : EventBase
{
	[Token(Token = "0x40014ED")]
	[FieldOffset(Offset = "0x30")]
	public string content;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002EFF")]
	public RailTextInputResult()
	{
	}
}
