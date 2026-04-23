using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002E7")]
public class GameServerInfo
{
	[Token(Token = "0x40011E5")]
	[FieldOffset(Offset = "0x10")]
	public List<RailKeyValue> server_kvs;

	[Token(Token = "0x40011E6")]
	[FieldOffset(Offset = "0x18")]
	public RailID owner_rail_id;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40011E7")]
	public string game_server_name;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40011E8")]
	public string server_fullname;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40011E9")]
	public bool is_dedicated;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40011EA")]
	public string server_info;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40011EB")]
	public string server_tags;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40011EC")]
	public string spectator_host;

	[Token(Token = "0x40011ED")]
	[FieldOffset(Offset = "0x50")]
	public string server_description;

	[Token(Token = "0x40011EE")]
	[FieldOffset(Offset = "0x58")]
	public string server_host;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40011EF")]
	public RailID game_server_rail_id;

	[Token(Token = "0x40011F0")]
	[FieldOffset(Offset = "0x68")]
	public bool has_password;

	[Token(Token = "0x40011F1")]
	[FieldOffset(Offset = "0x70")]
	public string server_version;

	[Token(Token = "0x40011F2")]
	[FieldOffset(Offset = "0x78")]
	public List<string> server_mods;

	[Token(Token = "0x40011F3")]
	[FieldOffset(Offset = "0x80")]
	public uint bot_players;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40011F4")]
	public string game_server_map;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40011F5")]
	public uint max_players;

	[Token(Token = "0x40011F6")]
	[FieldOffset(Offset = "0x94")]
	public uint current_players;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40011F7")]
	public bool is_friend_only;

	[Address(RVA = "0xD20070", Offset = "0xD1E870", Length = "0xE6")]
	[Token(Token = "0x6002DBF")]
	public GameServerInfo()
	{
	}
}
