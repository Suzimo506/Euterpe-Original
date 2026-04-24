using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002E8")]
public class GameServerListFilter
{
	[Token(Token = "0x40011F8")]
	[FieldOffset(Offset = "0x10")]
	public string tags_not_contained;

	[Token(Token = "0x40011F9")]
	[FieldOffset(Offset = "0x18")]
	public EnumRailOptionalValue filter_password;

	[Token(Token = "0x40011FA")]
	[FieldOffset(Offset = "0x20")]
	public string filter_game_server_name;

	[Token(Token = "0x40011FB")]
	[FieldOffset(Offset = "0x28")]
	public EnumRailOptionalValue filter_friends_created;

	[Token(Token = "0x40011FC")]
	[FieldOffset(Offset = "0x30")]
	public string tags_contained;

	[Token(Token = "0x40011FD")]
	[FieldOffset(Offset = "0x38")]
	public EnumRailOptionalValue filter_dedicated_server;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40011FE")]
	public List<GameServerListFilterKey> filters;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40011FF")]
	public string filter_game_server_map;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001200")]
	public string filter_game_server_host;

	[Token(Token = "0x4001201")]
	[FieldOffset(Offset = "0x58")]
	public RailID owner_id;

	[Token(Token = "0x6002DC0")]
	[Address(RVA = "0xD20160", Offset = "0xD1E960", Length = "0x91")]
	public GameServerListFilter()
	{
	}
}
