using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003B3")]
public class RailSpaceWorkUpdateOptions
{
	[Token(Token = "0x4001563")]
	[FieldOffset(Offset = "0x10")]
	public bool with_my_vote;

	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4001564")]
	public bool with_vote_detail;

	[Token(Token = "0x4001565")]
	[FieldOffset(Offset = "0x12")]
	public bool with_metadata;

	[FieldOffset(Offset = "0x13")]
	[Token(Token = "0x4001566")]
	public bool with_detail;

	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001567")]
	public bool check_has_subscribed;

	[Token(Token = "0x4001568")]
	[FieldOffset(Offset = "0x15")]
	public bool check_has_favorited;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002F5B")]
	public RailSpaceWorkUpdateOptions()
	{
	}
}
