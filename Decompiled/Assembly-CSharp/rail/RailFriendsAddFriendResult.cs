using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002C8")]
public class RailFriendsAddFriendResult : EventBase
{
	[Token(Token = "0x40011B9")]
	[FieldOffset(Offset = "0x30")]
	public RailID target_rail_id;

	[Address(RVA = "0x2720040", Offset = "0x271E840", Length = "0x9D")]
	[Token(Token = "0x6002D55")]
	public RailFriendsAddFriendResult()
	{
	}
}
