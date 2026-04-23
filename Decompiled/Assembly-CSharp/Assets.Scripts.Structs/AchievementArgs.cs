using Cpp2ILInjected;

namespace Assets.Scripts.Structs;

[Token(Token = "0x200057C")]
public struct AchievementArgs
{
	[Token(Token = "0x4002055")]
	[FieldOffset(Offset = "0x0")]
	public string musicUid;

	[Token(Token = "0x4002056")]
	[FieldOffset(Offset = "0x8")]
	public int difficulty;

	[Token(Token = "0x4002057")]
	[FieldOffset(Offset = "0xC")]
	public int evaluate;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002058")]
	public int score;

	[Token(Token = "0x4002059")]
	[FieldOffset(Offset = "0x14")]
	public int maxCombo;

	[Token(Token = "0x400205A")]
	[FieldOffset(Offset = "0x18")]
	public bool isFullCombo;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400205B")]
	public int comboMiss;

	[Token(Token = "0x400205C")]
	[FieldOffset(Offset = "0x20")]
	public int hurtMiss;

	[Token(Token = "0x400205D")]
	[FieldOffset(Offset = "0x24")]
	public int invokeFeverCount;
}
