using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200034C")]
public class GetRoomMembersResult : EventBase
{
	[Token(Token = "0x400144E")]
	[FieldOffset(Offset = "0x30")]
	public List<RoomMemberInfo> member_infos;

	[Token(Token = "0x400144F")]
	[FieldOffset(Offset = "0x38")]
	public ulong room_id;

	[Token(Token = "0x4001450")]
	[FieldOffset(Offset = "0x40")]
	public uint member_num;

	[Token(Token = "0x6002E7E")]
	[Address(RVA = "0xD20610", Offset = "0xD1EE10", Length = "0x69")]
	public GetRoomMembersResult()
	{
	}
}
