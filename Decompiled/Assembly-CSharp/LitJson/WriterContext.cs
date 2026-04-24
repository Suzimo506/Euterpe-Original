using Cpp2ILInjected;

namespace LitJson;

[Token(Token = "0x2000403")]
internal class WriterContext
{
	[Token(Token = "0x400164D")]
	[FieldOffset(Offset = "0x10")]
	public int Count;

	[Token(Token = "0x400164E")]
	[FieldOffset(Offset = "0x14")]
	public bool InArray;

	[Token(Token = "0x400164F")]
	[FieldOffset(Offset = "0x15")]
	public bool InObject;

	[Token(Token = "0x4001650")]
	[FieldOffset(Offset = "0x16")]
	public bool ExpectingValue;

	[Token(Token = "0x4001651")]
	[FieldOffset(Offset = "0x18")]
	public int Padding;

	[Token(Token = "0x60030D9")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public WriterContext()
	{
	}
}
