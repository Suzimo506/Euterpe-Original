using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007FB")]
public class DBConfigLocalUILocalization : BaseDBConfigObject
{
	[Token(Token = "0x40029A1")]
	[FieldOffset(Offset = "0x38")]
	private List<LocalUILocalizationInfo> m_Items;

	[Token(Token = "0x1700073B")]
	public LocalUILocalizationInfo uiLocalizationInfo
	{
		[Token(Token = "0x6004871")]
		[Address(RVA = "0x6FD980", Offset = "0x6FC180", Length = "0x4D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700073C")]
	protected List<LocalUILocalizationInfo> list
	{
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		[Token(Token = "0x6004872")]
		get
		{
			return null;
		}
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		[Token(Token = "0x6004873")]
		set
		{
		}
	}

	[Address(RVA = "0x6FD900", Offset = "0x6FC100", Length = "0x7A")]
	[Token(Token = "0x6004870")]
	public DBConfigLocalUILocalization()
	{
	}

	[Token(Token = "0x6004874")]
	[Address(RVA = "0x6FD790", Offset = "0x6FBF90", Length = "0x16D")]
	public override void Deserialize(string str)
	{
	}
}
