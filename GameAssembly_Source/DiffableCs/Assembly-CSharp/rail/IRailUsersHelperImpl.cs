namespace rail;

public class IRailUsersHelperImpl : RailObject, IRailUsersHelper
{

	internal IRailUsersHelperImpl(IntPtr cPtr) { }

	public override RailResult AsyncCancelAllInvites(string user_data) { }

	public override RailResult AsyncCancelInvite(EnumRailUsersInviteType invite_type, string user_data) { }

	public override RailResult AsyncGetInviteDetail(RailID inviter, EnumRailUsersInviteType invite_type, string user_data) { }

	public override RailResult AsyncGetUserLimits(RailID user_id, string user_data) { }

	public override RailResult AsyncGetUsersInfo(List<RailID> rail_ids, string user_data) { }

	public override RailResult AsyncInviteUsers(string command_line, List<RailID> users, RailInviteOptions options, string user_data) { }

	public override RailResult AsyncShowChatWindowWithFriend(RailID rail_id, string user_data) { }

	public override RailResult AsyncShowUserHomepageWindow(RailID rail_id, string user_data) { }

	protected virtual void Finalize() { }

}

