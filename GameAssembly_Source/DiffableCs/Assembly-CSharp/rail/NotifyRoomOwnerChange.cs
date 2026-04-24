namespace rail;

public class NotifyRoomOwnerChange : EventBase
{
	public RailID old_owner_id; //Field offset: 0x30
	public EnumRoomOwnerChangeReason reason; //Field offset: 0x38
	public ulong room_id; //Field offset: 0x40
	public RailID new_owner_id; //Field offset: 0x48

	public NotifyRoomOwnerChange() { }

}

