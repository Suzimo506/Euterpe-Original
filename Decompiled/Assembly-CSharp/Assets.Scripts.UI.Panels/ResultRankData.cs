using Cpp2ILInjected;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008F1")]
public class ResultRankData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002FAB")]
	public bool isNew;

	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4002FAC")]
	public int order;

	[Token(Token = "0x6005128")]
	[Address(RVA = "0x4D05D0", Offset = "0x4CEDD0", Length = "0x28")]
	public ResultRankData()
	{
	}

	[Token(Token = "0x6005129")]
	[Address(RVA = "0x4D05C0", Offset = "0x4CEDC0", Length = "0xC")]
	public void Reset()
	{
	}
}
