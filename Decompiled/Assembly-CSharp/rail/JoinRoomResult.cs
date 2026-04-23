using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000350")]
public class JoinRoomResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001455")]
	public ulong room_id;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002E82")]
	public JoinRoomResult()
	{
	}
}
