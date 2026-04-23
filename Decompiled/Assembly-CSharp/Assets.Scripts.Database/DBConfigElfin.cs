using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007C6")]
public class DBConfigElfin : BaseDBConfigLocalObject<DBConfigLocalElfin, LocalElfinInfo>
{
	[Token(Token = "0x4002907")]
	[FieldOffset(Offset = "0x40")]
	private List<ElfinInfo> m_Items;

	[Token(Token = "0x17000700")]
	protected List<ElfinInfo> list
	{
		[Token(Token = "0x600479E")]
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x600479F")]
		[Address(RVA = "0x6F4390", Offset = "0x6F2B90", Length = "0x36")]
		private set
		{
		}
	}

	[Token(Token = "0x17000701")]
	public int freeCount
	{
		[Address(RVA = "0x6F9A30", Offset = "0x6F8230", Length = "0x101")]
		[Token(Token = "0x60047A4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000702")]
	public int noHideCount
	{
		[Token(Token = "0x60047A6")]
		[Address(RVA = "0x6F9B40", Offset = "0x6F8340", Length = "0xFB")]
		get
		{
			return default(int);
		}
	}

	[Address(RVA = "0x6F9990", Offset = "0x6F8190", Length = "0x9C")]
	[Token(Token = "0x600479D")]
	public DBConfigElfin()
	{
		((BaseDBConfigLocalObject<, >)(object)this)._002Ector();
	}

	[Token(Token = "0x60047A0")]
	[Address(RVA = "0x6F9300", Offset = "0x6F7B00", Length = "0x100")]
	public override void Deserialize(string str)
	{
	}

	[Token(Token = "0x60047A1")]
	[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
	public List<ElfinInfo> GetAllDatas()
	{
		return null;
	}

	[Token(Token = "0x60047A2")]
	[Address(RVA = "0x6F94A0", Offset = "0x6F7CA0", Length = "0x164")]
	public ElfinInfo GetElfinInfoByOrder(int order)
	{
		return null;
	}

	[Token(Token = "0x60047A3")]
	[Address(RVA = "0x6F9410", Offset = "0x6F7C10", Length = "0x81")]
	public ElfinInfo GetElfinInfoByIndex(int index)
	{
		return null;
	}

	[Address(RVA = "0x6F9610", Offset = "0x6F7E10", Length = "0x116")]
	[Token(Token = "0x60047A5")]
	public int GetFreeCountByRarity(string rarity)
	{
		return default(int);
	}

	[Address(RVA = "0x6F9730", Offset = "0x6F7F30", Length = "0x250")]
	[Token(Token = "0x60047A7")]
	public List<int> GetLockedItemIndexList(List<int> unlockItemIdxs)
	{
		return null;
	}

	[Address(RVA = "0x6F91C0", Offset = "0x6F79C0", Length = "0x36")]
	[Token(Token = "0x60047A8")]
	private bool CheckInfoForLockItem(ElfinInfo info)
	{
		return default(bool);
	}

	[Address(RVA = "0x6F9200", Offset = "0x6F7A00", Length = "0xF9")]
	[Token(Token = "0x60047A9")]
	public int CompareInfoByIndex(int index1, int index2)
	{
		return default(int);
	}
}
