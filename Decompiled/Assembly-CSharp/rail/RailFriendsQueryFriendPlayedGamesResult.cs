using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002CF")]
public class RailFriendsQueryFriendPlayedGamesResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40011C0")]
	public List<RailFriendPlayedGameInfo> friend_played_games_info_list;

	[Token(Token = "0x6002D5C")]
	[Address(RVA = "0x2720330", Offset = "0x271EB30", Length = "0x69")]
	public RailFriendsQueryFriendPlayedGamesResult()
	{
	}
}
