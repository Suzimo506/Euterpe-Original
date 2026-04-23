using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000357")]
public class NotifyRoomMemberKicked : EventBase
{
	[Token(Token = "0x4001464")]
	[FieldOffset(Offset = "0x30")]
	public RailID id_for_making_kick;

	[Token(Token = "0x4001465")]
	[FieldOffset(Offset = "0x38")]
	public uint due_to_kicker_lost_connect;

	[Token(Token = "0x4001466")]
	[FieldOffset(Offset = "0x40")]
	public ulong room_id;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001467")]
	public RailID kicked_id;

	[Token(Token = "0x6002E89")]
	[Address(RVA = "0x37E820", Offset = "0x37D020", Length = "0x8C")]
	public NotifyRoomMemberKicked()
	{
	}
}
