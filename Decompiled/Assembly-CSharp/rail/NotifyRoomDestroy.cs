using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000354")]
public class NotifyRoomDestroy : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400145C")]
	public ulong room_id;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002E86")]
	public NotifyRoomDestroy()
	{
	}
}
