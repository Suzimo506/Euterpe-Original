using Cpp2ILInjected;
using rail;

namespace PeroPeroGames.DataStatistics;

[Token(Token = "0x20004F5")]
public class ThinkingDataWeGamePurchase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001AD6")]
	private ulong m_WeGameID;

	[Token(Token = "0x4001AD7")]
	[FieldOffset(Offset = "0x18")]
	private RailGameID m_ID;

	[Token(Token = "0x4001AD8")]
	[FieldOffset(Offset = "0x20")]
	private RailDlcInfo m_Info;

	[Token(Token = "0x6003701")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void Init()
	{
	}

	[Token(Token = "0x6003702")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public ThinkingDataWeGamePurchase()
	{
	}
}
