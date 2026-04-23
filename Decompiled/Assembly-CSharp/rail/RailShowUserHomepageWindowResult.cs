using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003C1")]
public class RailShowUserHomepageWindowResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001592")]
	public bool is_show;

	[Token(Token = "0x6002F6E")]
	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	public RailShowUserHomepageWindowResult()
	{
	}
}
