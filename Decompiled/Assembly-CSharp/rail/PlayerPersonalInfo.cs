using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000338")]
public class PlayerPersonalInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012B9")]
	public RailResult error_code;

	[Token(Token = "0x40012BA")]
	[FieldOffset(Offset = "0x18")]
	public string avatar_url;

	[Token(Token = "0x40012BB")]
	[FieldOffset(Offset = "0x20")]
	public uint rail_level;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40012BC")]
	public RailID rail_id;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40012BD")]
	public string rail_name;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40012BE")]
	public string email_address;

	[Token(Token = "0x6002E4A")]
	[Address(RVA = "0x37E940", Offset = "0x37D140", Length = "0x64")]
	public PlayerPersonalInfo()
	{
	}
}
