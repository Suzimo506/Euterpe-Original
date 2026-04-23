using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000366")]
public class SetRoomTypeResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001499")]
	public EnumRoomType room_type;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002E98")]
	public SetRoomTypeResult()
	{
	}
}
