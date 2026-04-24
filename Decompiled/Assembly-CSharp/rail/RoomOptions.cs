using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000360")]
public class RoomOptions
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001491")]
	public uint max_members;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001492")]
	public string password;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001493")]
	public EnumRoomType type;

	[Token(Token = "0x4001494")]
	[FieldOffset(Offset = "0x24")]
	public bool enable_team_voice;

	[Token(Token = "0x4001495")]
	[FieldOffset(Offset = "0x28")]
	public string room_tag;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002E92")]
	public RoomOptions()
	{
	}
}
