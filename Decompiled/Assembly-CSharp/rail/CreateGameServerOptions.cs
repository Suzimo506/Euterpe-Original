using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002E5")]
public class CreateGameServerOptions
{
	[Token(Token = "0x40011E2")]
	[FieldOffset(Offset = "0x10")]
	public bool has_password;

	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x40011E3")]
	public bool enable_team_voice;

	[Token(Token = "0x6002DBD")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public CreateGameServerOptions()
	{
	}
}
