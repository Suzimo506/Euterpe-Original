using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200038E")]
public class RailPlatformNotifyEventJoinGameByGameServer : EventBase
{
	[Token(Token = "0x40014DD")]
	[FieldOffset(Offset = "0x30")]
	public string commandline_info;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40014DE")]
	public RailID gameserver_railid;

	[Token(Token = "0x6002EF8")]
	[Address(RVA = "0x2720CC0", Offset = "0x271F4C0", Length = "0x9D")]
	public RailPlatformNotifyEventJoinGameByGameServer()
	{
	}
}
