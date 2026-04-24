using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x2000410")]
public enum ActivityType
{
	[Token(Token = "0x40016CC")]
	Playing,
	[Token(Token = "0x40016CD")]
	Streaming,
	[Token(Token = "0x40016CE")]
	Listening,
	[Token(Token = "0x40016CF")]
	Watching
}
