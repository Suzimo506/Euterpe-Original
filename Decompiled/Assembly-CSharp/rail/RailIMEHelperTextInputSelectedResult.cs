using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002FF")]
public class RailIMEHelperTextInputSelectedResult : EventBase
{
	[Token(Token = "0x4001225")]
	[FieldOffset(Offset = "0x30")]
	public string content;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002DE7")]
	public RailIMEHelperTextInputSelectedResult()
	{
	}
}
