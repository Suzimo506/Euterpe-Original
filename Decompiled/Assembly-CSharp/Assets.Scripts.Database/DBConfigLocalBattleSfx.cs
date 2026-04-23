using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000798")]
public class DBConfigLocalBattleSfx : BaseDBConfigObject
{
	[Token(Token = "0x4002827")]
	[FieldOffset(Offset = "0x38")]
	private List<LocalBattleSfxInfo> m_Items;

	[Token(Token = "0x170006BF")]
	protected List<LocalBattleSfxInfo> list
	{
		[Token(Token = "0x60046D0")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60046D1")]
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		private set
		{
		}
	}

	[Address(RVA = "0x6FBAC0", Offset = "0x6FA2C0", Length = "0x7A")]
	[Token(Token = "0x60046CF")]
	public DBConfigLocalBattleSfx()
	{
	}

	[Token(Token = "0x60046D2")]
	[Address(RVA = "0x6FB940", Offset = "0x6FA140", Length = "0x100")]
	public override void Deserialize(string str)
	{
	}

	[Token(Token = "0x60046D3")]
	[Address(RVA = "0x6FBA50", Offset = "0x6FA250", Length = "0x6B")]
	public LocalBattleSfxInfo GetInfoByIndex(int index)
	{
		return null;
	}
}
