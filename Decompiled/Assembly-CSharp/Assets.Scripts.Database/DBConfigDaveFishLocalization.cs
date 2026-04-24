using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007B5")]
public class DBConfigDaveFishLocalization : BaseDBConfigObject
{
	[Token(Token = "0x40028AD")]
	[FieldOffset(Offset = "0x38")]
	private List<DaveFishLocalizationData> m_Items;

	[Token(Token = "0x170006D9")]
	public List<DaveFishLocalizationData> DiveFishLocalizationList
	{
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		[Token(Token = "0x6004747")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006DA")]
	protected List<DaveFishLocalizationData> list
	{
		[Token(Token = "0x6004748")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		[Token(Token = "0x6004749")]
		set
		{
		}
	}

	[Address(RVA = "0x6F8570", Offset = "0x6F6D70", Length = "0x7A")]
	[Token(Token = "0x600474A")]
	public DBConfigDaveFishLocalization()
	{
	}

	[Address(RVA = "0x6F83A0", Offset = "0x6F6BA0", Length = "0x100")]
	[Token(Token = "0x600474B")]
	public override void Deserialize(string str)
	{
	}

	[Address(RVA = "0x6F84B0", Offset = "0x6F6CB0", Length = "0xB1")]
	[Token(Token = "0x600474C")]
	public string GetFishName(int uid)
	{
		return null;
	}
}
