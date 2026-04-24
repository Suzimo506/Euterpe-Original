using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200035C")]
public class RoomInfoListFilter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400147D")]
	public EnumRailOptionalValue filter_friends_in_room;

	[Token(Token = "0x400147E")]
	[FieldOffset(Offset = "0x18")]
	public string room_tag;

	[Token(Token = "0x400147F")]
	[FieldOffset(Offset = "0x20")]
	public uint available_slot_at_least;

	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001480")]
	public EnumRailOptionalValue filter_password;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001481")]
	public string room_name_contained;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001482")]
	public List<RoomInfoListFilterKey> key_filters;

	[Token(Token = "0x4001483")]
	[FieldOffset(Offset = "0x38")]
	public EnumRailOptionalValue filter_friends_owned;

	[Token(Token = "0x6002E8E")]
	[Address(RVA = "0x2721E90", Offset = "0x2720690", Length = "0x69")]
	public RoomInfoListFilter()
	{
	}
}
