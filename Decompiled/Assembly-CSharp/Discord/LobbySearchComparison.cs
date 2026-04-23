using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x2000416")]
public enum LobbySearchComparison
{
	[Token(Token = "0x40016E7")]
	LessThanOrEqual = -2,
	[Token(Token = "0x40016E8")]
	LessThan,
	[Token(Token = "0x40016E9")]
	Equal,
	[Token(Token = "0x40016EA")]
	GreaterThan,
	[Token(Token = "0x40016EB")]
	GreaterThanOrEqual,
	[Token(Token = "0x40016EC")]
	NotEqual
}
