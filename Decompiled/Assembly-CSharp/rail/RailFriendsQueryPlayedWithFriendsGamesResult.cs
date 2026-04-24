using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002D0")]
public class RailFriendsQueryPlayedWithFriendsGamesResult : EventBase
{
	[Token(Token = "0x40011C1")]
	[FieldOffset(Offset = "0x30")]
	public List<RailPlayedWithFriendsGameItem> played_with_friends_game_list;

	[Token(Token = "0x6002D5D")]
	[Address(RVA = "0x27203A0", Offset = "0x271EBA0", Length = "0x69")]
	public RailFriendsQueryPlayedWithFriendsGamesResult()
	{
	}
}
