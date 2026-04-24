using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000332")]
public class AcquireSessionTicketResponse : EventBase
{
	[Token(Token = "0x40012A4")]
	[FieldOffset(Offset = "0x30")]
	public RailSessionTicket session_ticket;

	[Address(RVA = "0xD1F130", Offset = "0xD1D930", Length = "0x64")]
	[Token(Token = "0x6002E47")]
	public AcquireSessionTicketResponse()
	{
	}
}
