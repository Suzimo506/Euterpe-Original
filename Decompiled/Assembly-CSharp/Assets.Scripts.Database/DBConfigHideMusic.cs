using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007D6")]
public class DBConfigHideMusic : BaseDBConfigObject
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002937")]
	private List<HideMusicInfo> m_Items;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002938")]
	private Dictionary<string, HideMusicInfo> m_HideMusicObjectMapping;

	[Token(Token = "0x1700070D")]
	protected List<HideMusicInfo> list
	{
		[Token(Token = "0x60047D7")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60047D8")]
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		private set
		{
		}
	}

	[Token(Token = "0x1700070E")]
	public Dictionary<string, HideMusicInfo> hideMusicObjectMapping
	{
		[Token(Token = "0x60047D9")]
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60047DA")]
	[Address(RVA = "0x6FA880", Offset = "0x6F9080", Length = "0xB9")]
	public DBConfigHideMusic()
	{
	}

	[Address(RVA = "0x6FA740", Offset = "0x6F8F40", Length = "0x134")]
	[Token(Token = "0x60047DB")]
	public override void Deserialize(string str)
	{
	}
}
