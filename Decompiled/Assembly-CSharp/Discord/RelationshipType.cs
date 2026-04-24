using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x2000414")]
public enum RelationshipType
{
	[Token(Token = "0x40016DD")]
	None,
	[Token(Token = "0x40016DE")]
	Friend,
	[Token(Token = "0x40016DF")]
	Blocked,
	[Token(Token = "0x40016E0")]
	PendingIncoming,
	[Token(Token = "0x40016E1")]
	PendingOutgoing,
	[Token(Token = "0x40016E2")]
	Implicit
}
