using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200035F")]
public class RoomMemberInfo
{
	[Token(Token = "0x400148C")]
	[FieldOffset(Offset = "0x10")]
	public string member_name;

	[Token(Token = "0x400148D")]
	[FieldOffset(Offset = "0x18")]
	public uint member_index;

	[Token(Token = "0x400148E")]
	[FieldOffset(Offset = "0x20")]
	public ulong room_id;

	[Token(Token = "0x400148F")]
	[FieldOffset(Offset = "0x28")]
	public List<RailKeyValue> member_kvs;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001490")]
	public RailID member_id;

	[Address(RVA = "0x2722030", Offset = "0x2720830", Length = "0xCA")]
	[Token(Token = "0x6002E91")]
	public RoomMemberInfo()
	{
	}
}
