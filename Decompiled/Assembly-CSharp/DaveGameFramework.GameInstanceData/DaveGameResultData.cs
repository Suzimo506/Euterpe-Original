using Cpp2ILInjected;

namespace DaveGameFramework.GameInstanceData;

[Token(Token = "0x20004BE")]
public class DaveGameResultData
{
	[Token(Token = "0x40019D9")]
	[FieldOffset(Offset = "0x10")]
	public int score;

	[Token(Token = "0x40019DA")]
	[FieldOffset(Offset = "0x14")]
	public int maxCombo;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40019DB")]
	public int comboMiss;

	[Token(Token = "0x40019DC")]
	[FieldOffset(Offset = "0x1C")]
	public int hitCount;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40019DD")]
	public int evaluate;

	[Token(Token = "0x40019DE")]
	[FieldOffset(Offset = "0x24")]
	public float rate;

	[Token(Token = "0x40019DF")]
	[FieldOffset(Offset = "0x28")]
	public int combo;

	[Token(Token = "0x6003571")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public DaveGameResultData()
	{
	}
}
