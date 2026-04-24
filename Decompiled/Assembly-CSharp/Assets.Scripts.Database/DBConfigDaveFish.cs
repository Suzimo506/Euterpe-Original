using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007B3")]
public class DBConfigDaveFish : BaseDBConfigLocalObject<DBConfigDaveFishLocalization, DaveFishLocalizationData>
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40028A9")]
	private List<DaveFishData> m_Items;

	[Token(Token = "0x170006D4")]
	public List<DaveFishData> DiveFishList
	{
		[Token(Token = "0x600473E")]
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006D5")]
	protected List<DaveFishData> list
	{
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		[Token(Token = "0x600473F")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004740")]
		[Address(RVA = "0x6F4390", Offset = "0x6F2B90", Length = "0x36")]
		set
		{
		}
	}

	[Token(Token = "0x6004741")]
	[Address(RVA = "0x6F8700", Offset = "0x6F6F00", Length = "0x7F")]
	public DBConfigDaveFish()
	{
		((BaseDBConfigLocalObject<, >)(object)this)._002Ector();
	}

	[Token(Token = "0x6004742")]
	[Address(RVA = "0x6F85F0", Offset = "0x6F6DF0", Length = "0x100")]
	public override void Deserialize(string str)
	{
	}
}
