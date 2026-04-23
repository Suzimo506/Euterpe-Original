using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000359")]
public class OpenRoomResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400146C")]
	public ulong room_id;

	[Token(Token = "0x6002E8B")]
	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	public OpenRoomResult()
	{
	}
}
