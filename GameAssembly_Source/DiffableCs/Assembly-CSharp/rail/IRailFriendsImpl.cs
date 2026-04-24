namespace rail;

public class IRailFriendsImpl : RailObject, IRailFriends
{

	internal IRailFriendsImpl(IntPtr cPtr) { }

	public override RailResult AsyncAddFriend(RailFriendsAddFriendRequest request, string user_data) { }

	public override RailResult AsyncClearAllMyMetadata(string user_data) { }

	public override RailResult AsyncGetFriendMetadata(RailID rail_id, List<String> keys, string user_data) { }

	public override RailResult AsyncGetInviteCommandLine(RailID rail_id, string user_data) { }

	public override RailResult AsyncGetPersonalInfo(List<RailID> rail_ids, string user_data) { }

	public override RailResult AsyncQueryFriendPlayedGamesInfo(RailID rail_id, string user_data) { }

	public override RailResult AsyncQueryPlayedWithFriendsGames(List<RailID> rail_ids, string user_data) { }

	public override RailResult AsyncQueryPlayedWithFriendsList(string user_data) { }

	public override RailResult AsyncQueryPlayedWithFriendsTime(List<RailID> rail_ids, string user_data) { }

	public override RailResult AsyncReportPlayedWithUserList(List<RailUserPlayedWith> player_list, string user_data) { }

	public override RailResult AsyncSetInviteCommandLine(string command_line, string user_data) { }

	public override RailResult AsyncSetMyMetadata(List<RailKeyValue> key_values, string user_data) { }

	public override RailResult AsyncUpdateFriendsData(string user_data) { }

	protected virtual void Finalize() { }

	public override RailResult GetFriendsList(List<RailFriendInfo> friends_list) { }

}

