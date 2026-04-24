using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000336")]
public class GetAuthenticateURLResult : EventBase
{
	[Token(Token = "0x40012B5")]
	[FieldOffset(Offset = "0x30")]
	public uint ticket_expire_time;

	[Token(Token = "0x40012B6")]
	[FieldOffset(Offset = "0x38")]
	public string authenticate_url;

	[Token(Token = "0x40012B7")]
	[FieldOffset(Offset = "0x40")]
	public string source_url;

	[Token(Token = "0x6002E48")]
	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	public GetAuthenticateURLResult()
	{
	}
}
