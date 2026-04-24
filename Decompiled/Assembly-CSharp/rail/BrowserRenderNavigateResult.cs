using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000289")]
public class BrowserRenderNavigateResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001020")]
	public string url;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002CE4")]
	public BrowserRenderNavigateResult()
	{
	}
}
