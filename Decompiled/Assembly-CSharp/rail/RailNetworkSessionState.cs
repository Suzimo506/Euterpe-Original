using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000330")]
public class RailNetworkSessionState
{
	[Token(Token = "0x400129C")]
	[FieldOffset(Offset = "0x10")]
	public RailResult session_error;

	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400129D")]
	public ushort remote_port;

	[Token(Token = "0x400129E")]
	[FieldOffset(Offset = "0x18")]
	public uint packets_in_send_buffer;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400129F")]
	public bool is_connecting;

	[Token(Token = "0x40012A0")]
	[FieldOffset(Offset = "0x20")]
	public uint bytes_in_send_buffer;

	[Token(Token = "0x40012A1")]
	[FieldOffset(Offset = "0x24")]
	public bool is_using_relay;

	[Token(Token = "0x40012A2")]
	[FieldOffset(Offset = "0x25")]
	public bool is_connection_active;

	[Token(Token = "0x40012A3")]
	[FieldOffset(Offset = "0x28")]
	public uint remote_ip;

	[Token(Token = "0x6002E36")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public RailNetworkSessionState()
	{
	}
}
