using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x200041A")]
public enum SkuType
{
	[Token(Token = "0x40016FE")]
	Application = 1,
	[Token(Token = "0x40016FF")]
	DLC,
	[Token(Token = "0x4001700")]
	Consumable,
	[Token(Token = "0x4001701")]
	Bundle
}
