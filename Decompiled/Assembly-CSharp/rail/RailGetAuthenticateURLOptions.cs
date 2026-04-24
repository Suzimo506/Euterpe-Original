using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200033B")]
public class RailGetAuthenticateURLOptions
{
	[Token(Token = "0x40012C1")]
	[FieldOffset(Offset = "0x10")]
	public string url;

	[Token(Token = "0x40012C2")]
	[FieldOffset(Offset = "0x18")]
	public string oauth2_state;

	[Token(Token = "0x40012C3")]
	[FieldOffset(Offset = "0x20")]
	public ulong client_id;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002E4D")]
	public RailGetAuthenticateURLOptions()
	{
	}
}
