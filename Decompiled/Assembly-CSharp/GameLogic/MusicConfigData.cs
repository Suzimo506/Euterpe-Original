using Cpp2ILInjected;

namespace GameLogic;

[Token(Token = "0x20004AB")]
public struct MusicConfigData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400196A")]
	public int id;

	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400196B")]
	public decimal time;

	[Token(Token = "0x400196C")]
	[FieldOffset(Offset = "0x18")]
	public string note_uid;

	[Token(Token = "0x400196D")]
	[FieldOffset(Offset = "0x20")]
	public decimal length;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400196E")]
	public bool blood;

	[Token(Token = "0x400196F")]
	[FieldOffset(Offset = "0x34")]
	public int pathway;
}
