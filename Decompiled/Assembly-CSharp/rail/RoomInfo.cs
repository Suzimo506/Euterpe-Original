using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200035B")]
public class RoomInfo
{
	[Token(Token = "0x4001471")]
	[FieldOffset(Offset = "0x10")]
	public bool has_password;

	[Token(Token = "0x4001472")]
	[FieldOffset(Offset = "0x14")]
	public uint max_members;

	[Token(Token = "0x4001473")]
	[FieldOffset(Offset = "0x18")]
	public string room_name;

	[Token(Token = "0x4001474")]
	[FieldOffset(Offset = "0x20")]
	public RailID game_server_rail_id;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001475")]
	public uint create_time;

	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001476")]
	public uint current_members;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001477")]
	public EnumRoomType type;

	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001478")]
	public bool is_joinable;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001479")]
	public ulong room_id;

	[Token(Token = "0x400147A")]
	[FieldOffset(Offset = "0x40")]
	public List<RailKeyValue> room_kvs;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400147B")]
	public string room_tag;

	[Token(Token = "0x400147C")]
	[FieldOffset(Offset = "0x50")]
	public RailID owner_id;

	[Token(Token = "0x6002E8D")]
	[Address(RVA = "0x2721F00", Offset = "0x2720700", Length = "0x12B")]
	public RoomInfo()
	{
	}
}
