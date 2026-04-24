namespace rail;

public class LeaveRoomResult : EventBase
{
	public EnumLeaveRoomReason reason; //Field offset: 0x30
	public ulong room_id; //Field offset: 0x38

	public LeaveRoomResult() { }

}

