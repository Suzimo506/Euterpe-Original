using Cpp2ILInjected;

namespace Assets.Scripts.Structs;

[Token(Token = "0x2000577")]
public struct NsGameStatisticsData
{
	[Token(Token = "0x400203E")]
	[FieldOffset(Offset = "0x0")]
	public uint music_index;

	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400203F")]
	public int music_difficulty;

	[Token(Token = "0x4002040")]
	[FieldOffset(Offset = "0x8")]
	public string character_uid;

	[Token(Token = "0x4002041")]
	[FieldOffset(Offset = "0x10")]
	public string elfin_uid;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002042")]
	public int hp;

	[Token(Token = "0x4002043")]
	[FieldOffset(Offset = "0x1C")]
	public int score;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002044")]
	public float acc;

	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4002045")]
	public int combo;

	[Token(Token = "0x4002046")]
	[FieldOffset(Offset = "0x28")]
	public string evaluate;

	[Token(Token = "0x4002047")]
	[FieldOffset(Offset = "0x30")]
	public int miss;

	[Address(RVA = "0x6579C0", Offset = "0x6561C0", Length = "0x70")]
	[Token(Token = "0x6003862")]
	public NsGameStatisticsData(uint nsMusicUid, int musicDifficulty, string roleUid, string elfinUid, int hp, int score, float accuracy, int combo, string evaluate, int miss)
	{
	}
}
