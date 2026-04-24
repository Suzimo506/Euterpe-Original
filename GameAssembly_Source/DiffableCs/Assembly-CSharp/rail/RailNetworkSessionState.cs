namespace rail;

public class RailNetworkSessionState
{
	public RailResult session_error; //Field offset: 0x10
	public ushort remote_port; //Field offset: 0x14
	public uint packets_in_send_buffer; //Field offset: 0x18
	public bool is_connecting; //Field offset: 0x1C
	public uint bytes_in_send_buffer; //Field offset: 0x20
	public bool is_using_relay; //Field offset: 0x24
	public bool is_connection_active; //Field offset: 0x25
	public uint remote_ip; //Field offset: 0x28

	public RailNetworkSessionState() { }

}

