using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002A2")]
public class RailSessionTicket
{
	[Token(Token = "0x4001078")]
	[FieldOffset(Offset = "0x10")]
	public string ticket;

	[Token(Token = "0x6002CFE")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public RailSessionTicket()
	{
	}
}
