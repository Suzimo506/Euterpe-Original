using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003C0")]
public class RailShowChatWindowWithFriendResult : EventBase
{
	[Token(Token = "0x4001591")]
	[FieldOffset(Offset = "0x30")]
	public bool is_show;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002F6D")]
	public RailShowChatWindowWithFriendResult()
	{
	}
}
