using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000292")]
public class JavascriptEventResult : EventBase
{
	[Token(Token = "0x400103F")]
	[FieldOffset(Offset = "0x30")]
	public string event_name;

	[Token(Token = "0x4001040")]
	[FieldOffset(Offset = "0x38")]
	public string event_value;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002CEC")]
	public JavascriptEventResult()
	{
	}
}
