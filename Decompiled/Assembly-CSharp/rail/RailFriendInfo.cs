using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002C2")]
public class RailFriendInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40011A6")]
	public RailID friend_rail_id;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40011A7")]
	public EnumRailFriendType friend_type;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40011A8")]
	public RailFriendOnLineState online_state;

	[Token(Token = "0x6002D50")]
	[Address(RVA = "0x271FC00", Offset = "0x271E400", Length = "0xC5")]
	public RailFriendInfo()
	{
	}
}
