using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000351")]
public class KickOffMemberResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001456")]
	public ulong room_id;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001457")]
	public RailID kicked_id;

	[Token(Token = "0x6002E83")]
	[Address(RVA = "0x37E200", Offset = "0x37CA00", Length = "0x64")]
	public KickOffMemberResult()
	{
	}
}
