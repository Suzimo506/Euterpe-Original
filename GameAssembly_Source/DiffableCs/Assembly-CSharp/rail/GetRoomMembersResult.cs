namespace rail;

public class GetRoomMembersResult : EventBase
{
	public List<RoomMemberInfo> member_infos; //Field offset: 0x30
	public ulong room_id; //Field offset: 0x38
	public uint member_num; //Field offset: 0x40

	public GetRoomMembersResult() { }

}

