using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200038F")]
public class RailPlatformNotifyEventJoinGameByRoom : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40014DF")]
	public string commandline_info;

	[Token(Token = "0x40014E0")]
	[FieldOffset(Offset = "0x38")]
	public ulong room_id;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002EF9")]
	public RailPlatformNotifyEventJoinGameByRoom()
	{
	}
}
