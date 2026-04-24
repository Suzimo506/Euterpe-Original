using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002FC")]
public class RailHttpSessionResponse : EventBase
{
	[Token(Token = "0x4001222")]
	[FieldOffset(Offset = "0x30")]
	public string http_response_data;

	[Token(Token = "0x6002DE3")]
	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	public RailHttpSessionResponse()
	{
	}
}
