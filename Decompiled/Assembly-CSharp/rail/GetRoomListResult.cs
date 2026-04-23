using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200034B")]
public class GetRoomListResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400144A")]
	public List<RoomInfo> room_infos;

	[Token(Token = "0x400144B")]
	[FieldOffset(Offset = "0x38")]
	public uint total_room_num;

	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400144C")]
	public uint begin_index;

	[Token(Token = "0x400144D")]
	[FieldOffset(Offset = "0x40")]
	public uint end_index;

	[Token(Token = "0x6002E7D")]
	[Address(RVA = "0xD205A0", Offset = "0xD1EDA0", Length = "0x69")]
	public GetRoomListResult()
	{
	}
}
