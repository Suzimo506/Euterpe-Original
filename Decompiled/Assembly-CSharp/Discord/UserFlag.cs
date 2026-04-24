using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x200040D")]
public enum UserFlag
{
	[Token(Token = "0x40016C0")]
	Partner = 2,
	[Token(Token = "0x40016C1")]
	HypeSquadEvents = 4,
	[Token(Token = "0x40016C2")]
	HypeSquadHouse1 = 0x40,
	[Token(Token = "0x40016C3")]
	HypeSquadHouse2 = 0x80,
	[Token(Token = "0x40016C4")]
	HypeSquadHouse3 = 0x100
}
