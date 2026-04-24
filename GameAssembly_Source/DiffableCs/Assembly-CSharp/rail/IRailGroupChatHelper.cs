namespace rail;

public interface IRailGroupChatHelper
{

	public IRailGroupChat AsyncOpenGroupChat(string group_id, string user_data) { }

	public RailResult AsyncQueryGroupsInfo(string user_data) { }

}

