using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002D1")]
public class RailFriendsQueryPlayedWithFriendsListResult : EventBase
{
	[Token(Token = "0x40011C2")]
	[FieldOffset(Offset = "0x30")]
	public List<RailID> played_with_friends_list;

	[Token(Token = "0x6002D5E")]
	[Address(RVA = "0x2720410", Offset = "0x271EC10", Length = "0x69")]
	public RailFriendsQueryPlayedWithFriendsListResult()
	{
	}
}
