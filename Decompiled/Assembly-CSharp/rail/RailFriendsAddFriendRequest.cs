using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002C7")]
public class RailFriendsAddFriendRequest
{
	[Token(Token = "0x40011B8")]
	[FieldOffset(Offset = "0x10")]
	public RailID target_rail_id;

	[Address(RVA = "0x271FFA0", Offset = "0x271E7A0", Length = "0x9D")]
	[Token(Token = "0x6002D54")]
	public RailFriendsAddFriendRequest()
	{
	}
}
