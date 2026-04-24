using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002D2")]
public class RailFriendsQueryPlayedWithFriendsTimeResult : EventBase
{
	[Token(Token = "0x40011C3")]
	[FieldOffset(Offset = "0x30")]
	public List<RailPlayedWithFriendsTimeItem> played_with_friends_time_list;

	[Token(Token = "0x6002D5F")]
	[Address(RVA = "0x2720480", Offset = "0x271EC80", Length = "0x69")]
	public RailFriendsQueryPlayedWithFriendsTimeResult()
	{
	}
}
