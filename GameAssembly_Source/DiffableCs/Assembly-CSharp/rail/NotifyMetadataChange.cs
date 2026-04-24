namespace rail;

public class NotifyMetadataChange : EventBase
{
	public RailID changer_id; //Field offset: 0x30
	public ulong room_id; //Field offset: 0x38

	public NotifyMetadataChange() { }

}

