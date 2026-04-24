using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007DC")]
public class DBConfigLoading : BaseDBConfigLocalObject<DBConfigLocalLoading, LocalLoadingInfo>
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002957")]
	private List<LoadingInfo> m_Items;

	[Token(Token = "0x17000717")]
	protected List<LoadingInfo> list
	{
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		[Token(Token = "0x60047EF")]
		get
		{
			return null;
		}
		[Address(RVA = "0x6F4390", Offset = "0x6F2B90", Length = "0x36")]
		[Token(Token = "0x60047F0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000718")]
	public int freeCount
	{
		[Address(RVA = "0x6FB3D0", Offset = "0x6F9BD0", Length = "0x10D")]
		[Token(Token = "0x60047F4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60047F1")]
	[Address(RVA = "0x6FB330", Offset = "0x6F9B30", Length = "0x9C")]
	public DBConfigLoading()
	{
		((BaseDBConfigLocalObject<, >)(object)this)._002Ector();
	}

	[Token(Token = "0x60047F2")]
	[Address(RVA = "0x6FAC90", Offset = "0x6F9490", Length = "0x100")]
	public override void Deserialize(string str)
	{
	}

	[Address(RVA = "0x6FAFF0", Offset = "0x6F97F0", Length = "0x6B")]
	[Token(Token = "0x60047F3")]
	public LoadingInfo GetLoadingInfoByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x60047F5")]
	[Address(RVA = "0x6FB060", Offset = "0x6F9860", Length = "0x252")]
	public List<int> GetLockedItemIndexList(List<int> unlockItemIdxs)
	{
		return null;
	}

	[Token(Token = "0x60047F6")]
	[Address(RVA = "0x6FAAF0", Offset = "0x6F92F0", Length = "0x36")]
	private bool CheckInfoForLockItem(LoadingInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x60047F7")]
	[Address(RVA = "0x6FAB30", Offset = "0x6F9330", Length = "0x151")]
	public int CompareInfoByIndex(int index1, int index2)
	{
		return default(int);
	}

	[Token(Token = "0x60047F8")]
	[Address(RVA = "0x6FADA0", Offset = "0x6F95A0", Length = "0x242")]
	public int GetLoadingHandleItemCount(List<IData> unlockItemIdxs)
	{
		return default(int);
	}

	[Token(Token = "0x60047F9")]
	[Address(RVA = "0x6FB2C0", Offset = "0x6F9AC0", Length = "0x65")]
	public bool IsExchange(int index)
	{
		return default(bool);
	}
}
