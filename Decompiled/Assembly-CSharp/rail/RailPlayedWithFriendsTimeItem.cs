using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002D7")]
public class RailPlayedWithFriendsTimeItem
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40011C9")]
	public uint play_time;

	[Token(Token = "0x40011CA")]
	[FieldOffset(Offset = "0x18")]
	public RailID rail_id;

	[Address(RVA = "0x2720ED0", Offset = "0x271F6D0", Length = "0x9D")]
	[Token(Token = "0x6002D64")]
	public RailPlayedWithFriendsTimeItem()
	{
	}
}
