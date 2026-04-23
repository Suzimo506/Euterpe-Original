using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000344")]
public class CreateRoomResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001435")]
	public ulong room_id;

	[Token(Token = "0x6002E7A")]
	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	public CreateRoomResult()
	{
	}
}
