namespace rail;

public class KickOffMemberResult : EventBase
{
	public ulong room_id; //Field offset: 0x30
	public RailID kicked_id; //Field offset: 0x38

	public KickOffMemberResult() { }

}

