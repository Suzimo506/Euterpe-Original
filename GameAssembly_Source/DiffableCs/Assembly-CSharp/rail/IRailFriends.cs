namespace rail;

public interface IRailFriends
{

	public RailResult AsyncAddFriend(RailFriendsAddFriendRequest request, string user_data) { }

	public RailResult AsyncClearAllMyMetadata(string user_data) { }

	public RailResult AsyncGetFriendMetadata(RailID rail_id, List<String> keys, string user_data) { }

	public RailResult AsyncGetInviteCommandLine(RailID rail_id, string user_data) { }

	public RailResult AsyncGetPersonalInfo(List<RailID> rail_ids, string user_data) { }

	public RailResult AsyncQueryFriendPlayedGamesInfo(RailID rail_id, string user_data) { }

	public RailResult AsyncQueryPlayedWithFriendsGames(List<RailID> rail_ids, string user_data) { }

	public RailResult AsyncQueryPlayedWithFriendsList(string user_data) { }

	public RailResult AsyncQueryPlayedWithFriendsTime(List<RailID> rail_ids, string user_data) { }

	public RailResult AsyncReportPlayedWithUserList(List<RailUserPlayedWith> player_list, string user_data) { }

	public RailResult AsyncSetInviteCommandLine(string command_line, string user_data) { }

	public RailResult AsyncSetMyMetadata(List<RailKeyValue> key_values, string user_data) { }

	public RailResult AsyncUpdateFriendsData(string user_data) { }

	public RailResult GetFriendsList(List<RailFriendInfo> friends_list) { }

}

