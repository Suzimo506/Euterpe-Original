using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007B8")]
public class DBConfigLocalDiscoActivity : BaseDBConfigObject
{
	[Token(Token = "0x40028B6")]
	[FieldOffset(Offset = "0x38")]
	private List<LocalDiscoActivityInfo> m_Items;

	[Token(Token = "0x170006DB")]
	protected List<LocalDiscoActivityInfo> list
	{
		[Token(Token = "0x6004750")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		[Token(Token = "0x6004751")]
		private set
		{
		}
	}

	[Token(Token = "0x600474F")]
	[Address(RVA = "0x6FC420", Offset = "0x6FAC20", Length = "0x7A")]
	public DBConfigLocalDiscoActivity()
	{
	}

	[Address(RVA = "0x6FC2A0", Offset = "0x6FAAA0", Length = "0x100")]
	[Token(Token = "0x6004752")]
	public override void Deserialize(string str)
	{
	}

	[Token(Token = "0x6004753")]
	[Address(RVA = "0x6FC3B0", Offset = "0x6FABB0", Length = "0x6B")]
	public LocalDiscoActivityInfo GetInfoByIndex(int index)
	{
		return null;
	}
}
