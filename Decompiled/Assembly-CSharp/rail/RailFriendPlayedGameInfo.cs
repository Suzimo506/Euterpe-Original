using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002C5")]
public class RailFriendPlayedGameInfo
{
	[Token(Token = "0x40011AE")]
	[FieldOffset(Offset = "0x10")]
	public bool in_room;

	[Token(Token = "0x40011AF")]
	[FieldOffset(Offset = "0x18")]
	public List<ulong> room_id_list;

	[Token(Token = "0x40011B0")]
	[FieldOffset(Offset = "0x20")]
	public RailID friend_id;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40011B1")]
	public List<ulong> game_server_id_list;

	[Token(Token = "0x40011B2")]
	[FieldOffset(Offset = "0x30")]
	public RailGameID game_id;

	[Token(Token = "0x40011B3")]
	[FieldOffset(Offset = "0x38")]
	public bool in_game_server;

	[Token(Token = "0x40011B4")]
	[FieldOffset(Offset = "0x3C")]
	public RailFriendPlayedGamePlayState friend_played_game_play_state;

	[Token(Token = "0x6002D53")]
	[Address(RVA = "0x271FE40", Offset = "0x271E640", Length = "0x158")]
	public RailFriendPlayedGameInfo()
	{
	}
}
