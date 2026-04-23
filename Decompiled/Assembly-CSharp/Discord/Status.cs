using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x2000413")]
public enum Status
{
	[Token(Token = "0x40016D8")]
	Offline,
	[Token(Token = "0x40016D9")]
	Online,
	[Token(Token = "0x40016DA")]
	Idle,
	[Token(Token = "0x40016DB")]
	DoNotDisturb
}
