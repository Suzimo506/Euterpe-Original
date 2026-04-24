using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200032B")]
public class CreateSessionFailed : EventBase
{
	[Token(Token = "0x4001292")]
	[FieldOffset(Offset = "0x30")]
	public RailID local_peer;

	[Token(Token = "0x4001293")]
	[FieldOffset(Offset = "0x38")]
	public RailID remote_peer;

	[Token(Token = "0x6002E31")]
	[Address(RVA = "0xD1F970", Offset = "0xD1E170", Length = "0x8C")]
	public CreateSessionFailed()
	{
	}
}
