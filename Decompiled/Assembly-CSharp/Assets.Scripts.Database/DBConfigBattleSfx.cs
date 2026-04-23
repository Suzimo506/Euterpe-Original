using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000799")]
public class DBConfigBattleSfx : BaseDBConfigLocalObject<DBConfigLocalBattleSfx, LocalBattleSfxInfo>
{
	[Token(Token = "0x4002828")]
	[FieldOffset(Offset = "0x40")]
	private List<BattleSfxInfo> m_Items;

	[Token(Token = "0x170006C0")]
	protected List<BattleSfxInfo> list
	{
		[Token(Token = "0x60046D5")]
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60046D6")]
		[Address(RVA = "0x6F4390", Offset = "0x6F2B90", Length = "0x36")]
		private set
		{
		}
	}

	[Token(Token = "0x170006C1")]
	public int freeCount
	{
		[Token(Token = "0x60046DA")]
		[Address(RVA = "0x6F5F80", Offset = "0x6F4780", Length = "0x104")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60046D4")]
	[Address(RVA = "0x6F5EE0", Offset = "0x6F46E0", Length = "0x9C")]
	public DBConfigBattleSfx()
	{
		((BaseDBConfigLocalObject<, >)(object)this)._002Ector();
	}

	[Token(Token = "0x60046D7")]
	[Address(RVA = "0x6F5B70", Offset = "0x6F4370", Length = "0x100")]
	public override void Deserialize(string str)
	{
	}

	[Address(RVA = "0x6F5C80", Offset = "0x6F4480", Length = "0x6B")]
	[Token(Token = "0x60046D8")]
	public BattleSfxInfo GetBattleSfxInfoByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x60046D9")]
	[Address(RVA = "0x6F5CF0", Offset = "0x6F44F0", Length = "0x172")]
	public BattleSfxInfo GetBattleSfxInfoByPackageUId(string uid)
	{
		return null;
	}

	[Token(Token = "0x60046DB")]
	[Address(RVA = "0x6F5E70", Offset = "0x6F4670", Length = "0x62")]
	public bool IsExchange(int index)
	{
		return default(bool);
	}
}
