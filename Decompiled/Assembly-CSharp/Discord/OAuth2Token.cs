using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x200041D")]
public struct OAuth2Token
{
	[Token(Token = "0x400170A")]
	[FieldOffset(Offset = "0x0")]
	public string AccessToken;

	[Token(Token = "0x400170B")]
	[FieldOffset(Offset = "0x8")]
	public string Scopes;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400170C")]
	public long Expires;
}
