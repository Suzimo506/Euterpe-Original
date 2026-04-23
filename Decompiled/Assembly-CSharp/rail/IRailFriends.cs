using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002BF")]
public interface IRailFriends
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D42")]
	RailResult AsyncGetPersonalInfo(List<RailID> rail_ids, string user_data);

	[Token(Token = "0x6002D43")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncGetFriendMetadata(RailID rail_id, List<string> keys, string user_data);

	[Token(Token = "0x6002D44")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncSetMyMetadata(List<RailKeyValue> key_values, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D45")]
	RailResult AsyncClearAllMyMetadata(string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D46")]
	RailResult AsyncSetInviteCommandLine(string command_line, string user_data);

	[Token(Token = "0x6002D47")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncGetInviteCommandLine(RailID rail_id, string user_data);

	[Token(Token = "0x6002D48")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncReportPlayedWithUserList(List<RailUserPlayedWith> player_list, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D49")]
	RailResult GetFriendsList(List<RailFriendInfo> friends_list);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D4A")]
	RailResult AsyncQueryFriendPlayedGamesInfo(RailID rail_id, string user_data);

	[Token(Token = "0x6002D4B")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncQueryPlayedWithFriendsList(string user_data);

	[Token(Token = "0x6002D4C")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncQueryPlayedWithFriendsTime(List<RailID> rail_ids, string user_data);

	[Token(Token = "0x6002D4D")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncQueryPlayedWithFriendsGames(List<RailID> rail_ids, string user_data);

	[Token(Token = "0x6002D4E")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncAddFriend(RailFriendsAddFriendRequest request, string user_data);

	[Token(Token = "0x6002D4F")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncUpdateFriendsData(string user_data);
}
