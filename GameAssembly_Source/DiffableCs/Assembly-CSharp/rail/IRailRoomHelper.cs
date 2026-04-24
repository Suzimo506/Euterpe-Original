namespace rail;

public interface IRailRoomHelper
{

	public IRailRoom AsyncCreateRoom(RoomOptions options, string room_name, string user_data) { }

	public RailResult AsyncGetRoomList(uint start_index, uint end_index, List<RoomInfoListSorter> sorter, List<RoomInfoListFilter> filter, string user_data) { }

	public RailResult AsyncGetRoomListByTags(uint start_index, uint end_index, List<RoomInfoListSorter> sorter, List<String> room_tags, string user_data) { }

	public RailResult AsyncGetUserRoomList(string user_data) { }

	public IRailRoom AsyncOpenRoom(ulong room_id, string user_data) { }

	public IRailRoom CreateRoom(RoomOptions options, string room_name, out RailResult result) { }

	public IRailRoom OpenRoom(ulong room_id, out RailResult result) { }

}

