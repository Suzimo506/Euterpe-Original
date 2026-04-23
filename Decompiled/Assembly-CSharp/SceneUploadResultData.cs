using Cpp2ILInjected;

[Token(Token = "0x200002D")]
public struct SceneUploadResultData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000D0")]
	public string musicUid;

	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x8")]
	public int musicDifficulty;

	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0x10")]
	public string roleUid;

	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0x18")]
	public string elfinUid;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000D4")]
	public int hp;

	[Token(Token = "0x40000D5")]
	[FieldOffset(Offset = "0x24")]
	public int score;

	[Token(Token = "0x40000D6")]
	[FieldOffset(Offset = "0x28")]
	public float accuracy;

	[Token(Token = "0x40000D7")]
	[FieldOffset(Offset = "0x2C")]
	public int combo;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000D8")]
	public string evaluate;

	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0x38")]
	public int miss;

	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0x40")]
	public string stageInfoMd5;

	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0x48")]
	public int musicStartDelay;
}
