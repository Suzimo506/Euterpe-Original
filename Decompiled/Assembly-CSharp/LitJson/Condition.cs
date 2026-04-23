using Cpp2ILInjected;

namespace LitJson;

[Token(Token = "0x2000402")]
internal enum Condition
{
	[Token(Token = "0x4001648")]
	InArray,
	[Token(Token = "0x4001649")]
	InObject,
	[Token(Token = "0x400164A")]
	NotAProperty,
	[Token(Token = "0x400164B")]
	Property,
	[Token(Token = "0x400164C")]
	Value
}
