using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200034F")]
public class GetUserRoomListResult : EventBase
{
	[Token(Token = "0x4001454")]
	[FieldOffset(Offset = "0x30")]
	public List<RoomInfo> room_info;

	[Address(RVA = "0xD206F0", Offset = "0xD1EEF0", Length = "0x69")]
	[Token(Token = "0x6002E81")]
	public GetUserRoomListResult()
	{
	}
}
