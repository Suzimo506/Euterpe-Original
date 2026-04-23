using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002C4")]
public class RailFriendOnLineState
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40011AB")]
	public RailID friend_rail_id;

	[Token(Token = "0x40011AC")]
	[FieldOffset(Offset = "0x18")]
	public uint game_define_game_playing_state;

	[Token(Token = "0x40011AD")]
	[FieldOffset(Offset = "0x1C")]
	public EnumRailPlayerOnLineState friend_online_state;

	[Address(RVA = "0x271FDA0", Offset = "0x271E5A0", Length = "0x9D")]
	[Token(Token = "0x6002D52")]
	public RailFriendOnLineState()
	{
	}
}
