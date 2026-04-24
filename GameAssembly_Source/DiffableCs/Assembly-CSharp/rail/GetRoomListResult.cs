namespace rail;

public class GetRoomListResult : EventBase
{
	public List<RoomInfo> room_infos; //Field offset: 0x30
	public uint total_room_num; //Field offset: 0x38
	public uint begin_index; //Field offset: 0x3C
	public uint end_index; //Field offset: 0x40

	public GetRoomListResult() { }

}

