using Cpp2ILInjected;

namespace LitJson;

[Token(Token = "0x2000400")]
public enum JsonToken
{
	[Token(Token = "0x400162C")]
	None,
	[Token(Token = "0x400162D")]
	ObjectStart,
	[Token(Token = "0x400162E")]
	PropertyName,
	[Token(Token = "0x400162F")]
	ObjectEnd,
	[Token(Token = "0x4001630")]
	ArrayStart,
	[Token(Token = "0x4001631")]
	ArrayEnd,
	[Token(Token = "0x4001632")]
	Int,
	[Token(Token = "0x4001633")]
	Long,
	[Token(Token = "0x4001634")]
	Double,
	[Token(Token = "0x4001635")]
	String,
	[Token(Token = "0x4001636")]
	Boolean,
	[Token(Token = "0x4001637")]
	Null
}
