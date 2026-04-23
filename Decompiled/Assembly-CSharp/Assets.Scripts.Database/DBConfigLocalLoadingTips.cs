using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007DF")]
public class DBConfigLocalLoadingTips : BaseDBConfigObject
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400295A")]
	private List<LocalLoadingTipsInfo> m_Items;

	[Token(Token = "0x17000719")]
	private List<LocalLoadingTipsInfo> list
	{
		[Token(Token = "0x60047FC")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60047FD")]
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		set
		{
		}
	}

	[Token(Token = "0x60047FE")]
	[Address(RVA = "0x6FD1D0", Offset = "0x6FB9D0", Length = "0x7A")]
	public DBConfigLocalLoadingTips()
	{
	}

	[Token(Token = "0x60047FF")]
	[Address(RVA = "0x6FCF60", Offset = "0x6FB760", Length = "0x100")]
	public override void Deserialize(string str)
	{
	}

	[Token(Token = "0x6004800")]
	[Address(RVA = "0x6FD160", Offset = "0x6FB960", Length = "0x6B")]
	public LocalLoadingTipsInfo GetInfoByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x6004801")]
	[Address(RVA = "0x6FD070", Offset = "0x6FB870", Length = "0xEA")]
	public void GetAllTips(List<string> buffer, bool clear)
	{
	}
}
