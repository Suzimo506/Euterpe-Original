using System.Collections.Generic;
using Assets.Scripts.Database;
using Cpp2ILInjected;

[Token(Token = "0x2000026")]
public class DBConfigRankBan : BaseDBConfigObject
{
	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x38")]
	private List<string> m_Item;

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x46B570", Offset = "0x469D70", Length = "0x8C")]
	public DBConfigRankBan()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x46B510", Offset = "0x469D10", Length = "0x52")]
	public bool IsBMSMapRankBan(string mapName)
	{
		return default(bool);
	}

	[Address(RVA = "0x46B490", Offset = "0x469C90", Length = "0x71")]
	[Token(Token = "0x6000100")]
	public override void Deserialize(string str)
	{
	}
}
