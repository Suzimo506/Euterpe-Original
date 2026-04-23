using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000343")]
public class ClearRoomMetadataResult : EventBase
{
	[Token(Token = "0x4001434")]
	[FieldOffset(Offset = "0x30")]
	public ulong room_id;

	[Token(Token = "0x6002E79")]
	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	public ClearRoomMetadataResult()
	{
	}
}
