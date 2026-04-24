using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000358")]
public class NotifyRoomOwnerChange : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001468")]
	public RailID old_owner_id;

	[Token(Token = "0x4001469")]
	[FieldOffset(Offset = "0x38")]
	public EnumRoomOwnerChangeReason reason;

	[Token(Token = "0x400146A")]
	[FieldOffset(Offset = "0x40")]
	public ulong room_id;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400146B")]
	public RailID new_owner_id;

	[Address(RVA = "0x37E8B0", Offset = "0x37D0B0", Length = "0x8C")]
	[Token(Token = "0x6002E8A")]
	public NotifyRoomOwnerChange()
	{
	}
}
