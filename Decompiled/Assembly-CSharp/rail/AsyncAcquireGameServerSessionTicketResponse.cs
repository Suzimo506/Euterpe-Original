using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002E1")]
public class AsyncAcquireGameServerSessionTicketResponse : EventBase
{
	[Token(Token = "0x40011DE")]
	[FieldOffset(Offset = "0x30")]
	public RailSessionTicket session_ticket;

	[Token(Token = "0x6002DB9")]
	[Address(RVA = "0xD1F1A0", Offset = "0xD1D9A0", Length = "0x64")]
	public AsyncAcquireGameServerSessionTicketResponse()
	{
	}
}
