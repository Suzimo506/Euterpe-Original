using Cpp2ILInjected;

namespace LitJson;

[Token(Token = "0x2000405")]
internal class FsmContext
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400165D")]
	public bool Return;

	[Token(Token = "0x400165E")]
	[FieldOffset(Offset = "0x14")]
	public int NextState;

	[Token(Token = "0x400165F")]
	[FieldOffset(Offset = "0x18")]
	public Lexer L;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001660")]
	public int StateStack;

	[Token(Token = "0x60030FC")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public FsmContext()
	{
	}
}
