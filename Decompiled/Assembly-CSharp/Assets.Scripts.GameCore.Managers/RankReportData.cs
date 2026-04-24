using Assets.Scripts.Database;
using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000753")]
public class RankReportData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40026BB")]
	public MusicInfo musicInfo;

	[Token(Token = "0x40026BC")]
	[FieldOffset(Offset = "0x18")]
	public int selectDiff;

	[Token(Token = "0x40026BD")]
	[FieldOffset(Offset = "0x1C")]
	public int score;

	[Token(Token = "0x40026BE")]
	[FieldOffset(Offset = "0x20")]
	public float accuracy;

	[Token(Token = "0x40026BF")]
	[FieldOffset(Offset = "0x24")]
	public int combo;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40026C0")]
	public string evaluate;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40026C1")]
	public int order;

	[Address(RVA = "0x6DC6C0", Offset = "0x6DAEC0", Length = "0x82")]
	[Token(Token = "0x60044E9")]
	public RankReportData(MusicInfo MusicInfo, int SelectDiff, int Score, float Accuracy, int Combo, string Evaluate, int Order = -1)
	{
	}
}
