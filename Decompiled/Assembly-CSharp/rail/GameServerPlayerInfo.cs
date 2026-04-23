using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002EC")]
public class GameServerPlayerInfo
{
	[Token(Token = "0x400120E")]
	[FieldOffset(Offset = "0x10")]
	public string member_nickname;

	[Token(Token = "0x400120F")]
	[FieldOffset(Offset = "0x18")]
	public long member_score;

	[Token(Token = "0x4001210")]
	[FieldOffset(Offset = "0x20")]
	public RailID member_id;

	[Address(RVA = "0xD20200", Offset = "0xD1EA00", Length = "0x64")]
	[Token(Token = "0x6002DC3")]
	public GameServerPlayerInfo()
	{
	}
}
