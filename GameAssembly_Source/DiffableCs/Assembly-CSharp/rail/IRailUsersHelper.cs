namespace rail;

public interface IRailUsersHelper
{

	public RailResult AsyncCancelAllInvites(string user_data) { }

	public RailResult AsyncCancelInvite(EnumRailUsersInviteType invite_type, string user_data) { }

	public RailResult AsyncGetInviteDetail(RailID inviter, EnumRailUsersInviteType invite_type, string user_data) { }

	public RailResult AsyncGetUserLimits(RailID user_id, string user_data) { }

	public RailResult AsyncGetUsersInfo(List<RailID> rail_ids, string user_data) { }

	public RailResult AsyncInviteUsers(string command_line, List<RailID> users, RailInviteOptions options, string user_data) { }

	public RailResult AsyncShowChatWindowWithFriend(RailID rail_id, string user_data) { }

	public RailResult AsyncShowUserHomepageWindow(RailID rail_id, string user_data) { }

}

