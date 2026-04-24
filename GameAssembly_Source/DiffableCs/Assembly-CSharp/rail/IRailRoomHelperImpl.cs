namespace rail;

public class IRailRoomHelperImpl : RailObject, IRailRoomHelper
{

	internal IRailRoomHelperImpl(IntPtr cPtr) { }

	public override IRailRoom AsyncCreateRoom(RoomOptions options, string room_name, string user_data) { }

	public override RailResult AsyncGetRoomList(uint start_index, uint end_index, List<RoomInfoListSorter> sorter, List<RoomInfoListFilter> filter, string user_data) { }

	public override RailResult AsyncGetRoomListByTags(uint start_index, uint end_index, List<RoomInfoListSorter> sorter, List<String> room_tags, string user_data) { }

	public override RailResult AsyncGetUserRoomList(string user_data) { }

	public override IRailRoom AsyncOpenRoom(ulong room_id, string user_data) { }

	public override IRailRoom CreateRoom(RoomOptions options, string room_name, out RailResult result) { }

	protected virtual void Finalize() { }

	public override IRailRoom OpenRoom(ulong room_id, out RailResult result) { }

}

