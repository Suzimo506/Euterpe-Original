using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200032C")]
public class CreateSessionRequest : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001294")]
	public RailID local_peer;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001295")]
	public RailID remote_peer;

	[Token(Token = "0x6002E32")]
	[Address(RVA = "0xD1FA00", Offset = "0xD1E200", Length = "0x8C")]
	public CreateSessionRequest()
	{
	}
}
