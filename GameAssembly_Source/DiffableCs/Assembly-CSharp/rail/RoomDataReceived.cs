namespace rail;

public class RoomDataReceived : EventBase
{
	public uint data_len; //Field offset: 0x30
	public RailID remote_peer; //Field offset: 0x38
	public uint message_type; //Field offset: 0x40
	public string data_buf; //Field offset: 0x48

	public RoomDataReceived() { }

}

