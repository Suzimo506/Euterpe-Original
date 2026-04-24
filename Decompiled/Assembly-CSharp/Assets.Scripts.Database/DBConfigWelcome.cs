using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000806")]
public class DBConfigWelcome : BaseDBConfigLocalObject<DBConfigLocalWelcome, LocalWelcomeInfo>
{
	[Token(Token = "0x40029D2")]
	[FieldOffset(Offset = "0x40")]
	private List<WelcomeInfo> m_Items;

	[Token(Token = "0x17000746")]
	protected List<WelcomeInfo> list
	{
		[Token(Token = "0x60048A1")]
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60048A2")]
		[Address(RVA = "0x6F4390", Offset = "0x6F2B90", Length = "0x36")]
		private set
		{
		}
	}

	[Token(Token = "0x17000747")]
	public int freeCount
	{
		[Token(Token = "0x60048A5")]
		[Address(RVA = "0x1025ED0", Offset = "0x10246D0", Length = "0x104")]
		get
		{
			return default(int);
		}
	}

	[Address(RVA = "0x1025E30", Offset = "0x1024630", Length = "0x9C")]
	[Token(Token = "0x60048A0")]
	public DBConfigWelcome()
	{
		((BaseDBConfigLocalObject<, >)(object)this)._002Ector();
	}

	[Token(Token = "0x60048A3")]
	[Address(RVA = "0x10257B0", Offset = "0x1023FB0", Length = "0x100")]
	public override void Deserialize(string str)
	{
	}

	[Address(RVA = "0x1025D50", Offset = "0x1024550", Length = "0x6B")]
	[Token(Token = "0x60048A4")]
	public WelcomeInfo GetWelcomeInfoByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x60048A6")]
	[Address(RVA = "0x10258C0", Offset = "0x10240C0", Length = "0x243")]
	public List<int> GetLockedItemIndexList(List<int> unlockItemIdxs)
	{
		return null;
	}

	[Token(Token = "0x60048A7")]
	[Address(RVA = "0x1025630", Offset = "0x1023E30", Length = "0x2D")]
	private bool CheckInfoForLockItem(WelcomeInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x60048A8")]
	[Address(RVA = "0x1025660", Offset = "0x1023E60", Length = "0x144")]
	public int CompareInfoByIndex(int index1, int index2)
	{
		return default(int);
	}

	[Token(Token = "0x60048A9")]
	[Address(RVA = "0x1025B10", Offset = "0x1024310", Length = "0x23F")]
	public int GetWelcomeHandleItemCount(List<IData> unlockItemIdxs)
	{
		return default(int);
	}

	[Token(Token = "0x60048AA")]
	[Address(RVA = "0x1025DC0", Offset = "0x10245C0", Length = "0x62")]
	public bool IsExchange(int index)
	{
		return default(bool);
	}
}
