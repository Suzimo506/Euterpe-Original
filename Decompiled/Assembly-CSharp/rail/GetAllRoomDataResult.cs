using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000349")]
public class GetAllRoomDataResult : EventBase
{
	[Token(Token = "0x4001446")]
	[FieldOffset(Offset = "0x30")]
	public RoomInfo room_info;

	[Address(RVA = "0xD202E0", Offset = "0xD1EAE0", Length = "0x64")]
	[Token(Token = "0x6002E7B")]
	public GetAllRoomDataResult()
	{
	}
}
