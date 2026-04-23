using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200033F")]
public class StartSessionWithPlayerResponse : EventBase
{
	[Token(Token = "0x40012CA")]
	[FieldOffset(Offset = "0x30")]
	public RailID remote_rail_id;

	[Address(RVA = "0x27223B0", Offset = "0x2720BB0", Length = "0x9D")]
	[Token(Token = "0x6002E50")]
	public StartSessionWithPlayerResponse()
	{
	}
}
