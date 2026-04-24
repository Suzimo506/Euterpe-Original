using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003BF")]
public class RailInviteOptions
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400158D")]
	public string additional_message;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400158E")]
	public uint expire_time;

	[Token(Token = "0x400158F")]
	[FieldOffset(Offset = "0x1C")]
	public EnumRailUsersInviteType invite_type;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001590")]
	public bool need_respond_in_game;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002F6C")]
	public RailInviteOptions()
	{
	}
}
