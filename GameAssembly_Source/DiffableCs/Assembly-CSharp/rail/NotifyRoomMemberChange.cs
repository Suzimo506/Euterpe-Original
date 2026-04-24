namespace rail;

public class NotifyRoomMemberChange : EventBase
{
	public RailID changer_id; //Field offset: 0x30
	public RailID id_for_making_change; //Field offset: 0x38
	public EnumRoomMemberActionStatus state_change; //Field offset: 0x40
	public ulong room_id; //Field offset: 0x48

	public NotifyRoomMemberChange() { }

}

