using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000352")]
public class LeaveRoomResult : EventBase
{
	[Token(Token = "0x4001458")]
	[FieldOffset(Offset = "0x30")]
	public EnumLeaveRoomReason reason;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001459")]
	public ulong room_id;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002E84")]
	public LeaveRoomResult()
	{
	}
}
