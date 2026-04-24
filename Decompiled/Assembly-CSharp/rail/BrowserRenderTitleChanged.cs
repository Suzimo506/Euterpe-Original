using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200028B")]
public class BrowserRenderTitleChanged : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001023")]
	public string new_title;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002CE6")]
	public BrowserRenderTitleChanged()
	{
	}
}
