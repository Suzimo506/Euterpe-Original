namespace rail;

public class NotifyRoomMemberKicked : EventBase
{
	public RailID id_for_making_kick; //Field offset: 0x30
	public uint due_to_kicker_lost_connect; //Field offset: 0x38
	public ulong room_id; //Field offset: 0x40
	public RailID kicked_id; //Field offset: 0x48

	public NotifyRoomMemberKicked() { }

}

