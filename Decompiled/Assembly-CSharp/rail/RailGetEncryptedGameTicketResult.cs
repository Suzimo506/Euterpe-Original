using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200033C")]
public class RailGetEncryptedGameTicketResult : EventBase
{
	[Token(Token = "0x40012C4")]
	[FieldOffset(Offset = "0x30")]
	public string encrypted_game_ticket;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002E4E")]
	public RailGetEncryptedGameTicketResult()
	{
	}
}
