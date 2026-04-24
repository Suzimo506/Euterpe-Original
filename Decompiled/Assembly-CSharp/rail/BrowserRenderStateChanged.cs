using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200028A")]
public class BrowserRenderStateChanged : EventBase
{
	[Token(Token = "0x4001021")]
	[FieldOffset(Offset = "0x30")]
	public bool can_go_back;

	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4001022")]
	public bool can_go_forward;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002CE5")]
	public BrowserRenderStateChanged()
	{
	}
}
