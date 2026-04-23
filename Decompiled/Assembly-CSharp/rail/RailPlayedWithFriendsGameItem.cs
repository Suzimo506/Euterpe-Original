using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002D6")]
public class RailPlayedWithFriendsGameItem
{
	[Token(Token = "0x40011C7")]
	[FieldOffset(Offset = "0x10")]
	public List<RailGameID> game_ids;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40011C8")]
	public RailID rail_id;

	[Address(RVA = "0x2720E00", Offset = "0x271F600", Length = "0xCA")]
	[Token(Token = "0x6002D63")]
	public RailPlayedWithFriendsGameItem()
	{
	}
}
