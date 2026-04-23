using Cpp2ILInjected;

namespace LitJson;

[Token(Token = "0x2000407")]
internal enum ParserToken
{
	[Token(Token = "0x4001670")]
	None = 65536,
	[Token(Token = "0x4001671")]
	Number,
	[Token(Token = "0x4001672")]
	True,
	[Token(Token = "0x4001673")]
	False,
	[Token(Token = "0x4001674")]
	Null,
	[Token(Token = "0x4001675")]
	CharSeq,
	[Token(Token = "0x4001676")]
	Char,
	[Token(Token = "0x4001677")]
	Text,
	[Token(Token = "0x4001678")]
	Object,
	[Token(Token = "0x4001679")]
	ObjectPrime,
	[Token(Token = "0x400167A")]
	Pair,
	[Token(Token = "0x400167B")]
	PairRest,
	[Token(Token = "0x400167C")]
	Array,
	[Token(Token = "0x400167D")]
	ArrayPrime,
	[Token(Token = "0x400167E")]
	Value,
	[Token(Token = "0x400167F")]
	ValueRest,
	[Token(Token = "0x4001680")]
	String,
	[Token(Token = "0x4001681")]
	End,
	[Token(Token = "0x4001682")]
	Epsilon
}
