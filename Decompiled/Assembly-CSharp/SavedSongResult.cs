using Cpp2ILInjected;

[Token(Token = "0x2000054")]
public struct SavedSongResult
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001EC")]
	public string uid;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001ED")]
	public int evaluate;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001EE")]
	public long score;

	[Token(Token = "0x40001EF")]
	[FieldOffset(Offset = "0x18")]
	public int combo;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40001F0")]
	public float accuracy;

	[Token(Token = "0x40001F1")]
	[FieldOffset(Offset = "0x20")]
	public string accuracyStr;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001F2")]
	public float clear;

	[Token(Token = "0x40001F3")]
	[FieldOffset(Offset = "0x2C")]
	public int difficultyLevel;
}
