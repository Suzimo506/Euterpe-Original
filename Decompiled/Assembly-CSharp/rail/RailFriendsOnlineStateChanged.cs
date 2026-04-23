using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002CE")]
public class RailFriendsOnlineStateChanged : EventBase
{
	[Token(Token = "0x40011BF")]
	[FieldOffset(Offset = "0x30")]
	public RailFriendOnLineState friend_online_state;

	[Token(Token = "0x6002D5B")]
	[Address(RVA = "0x27202C0", Offset = "0x271EAC0", Length = "0x64")]
	public RailFriendsOnlineStateChanged()
	{
	}
}
