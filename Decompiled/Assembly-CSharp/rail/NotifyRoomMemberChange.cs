using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000356")]
public class NotifyRoomMemberChange : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001460")]
	public RailID changer_id;

	[Token(Token = "0x4001461")]
	[FieldOffset(Offset = "0x38")]
	public RailID id_for_making_change;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001462")]
	public EnumRoomMemberActionStatus state_change;

	[Token(Token = "0x4001463")]
	[FieldOffset(Offset = "0x48")]
	public ulong room_id;

	[Token(Token = "0x6002E88")]
	[Address(RVA = "0x37E790", Offset = "0x37CF90", Length = "0x8C")]
	public NotifyRoomMemberChange()
	{
	}
}
