using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007BF")]
public class DBConfigDlcBillboard : BaseDBConfigLocalObject<DBConfigLocalDlcBillboard, LocalDlcBillboardInfo>
{
	[Token(Token = "0x40028D0")]
	[FieldOffset(Offset = "0x40")]
	private List<DlcBillboardInfo> m_Items;

	[Token(Token = "0x170006E5")]
	protected List<DlcBillboardInfo> list
	{
		[Token(Token = "0x600476F")]
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004770")]
		[Address(RVA = "0x6F4390", Offset = "0x6F2B90", Length = "0x36")]
		private set
		{
		}
	}

	[Token(Token = "0x600476E")]
	[Address(RVA = "0x6F8E20", Offset = "0x6F7620", Length = "0x9C")]
	public DBConfigDlcBillboard()
	{
		((BaseDBConfigLocalObject<, >)(object)this)._002Ector();
	}

	[Token(Token = "0x6004771")]
	[Address(RVA = "0x6F8CB0", Offset = "0x6F74B0", Length = "0x164")]
	public DlcBillboardInfo GetBillboardInfoByJsonIndex(int jsonIndex)
	{
		return null;
	}

	[Token(Token = "0x6004772")]
	[Address(RVA = "0x6F8C50", Offset = "0x6F7450", Length = "0x5A")]
	public DlcBillboardInfo GetBillboardInfoByIndex(int index)
	{
		return null;
	}

	[Address(RVA = "0x6F8B40", Offset = "0x6F7340", Length = "0x100")]
	[Token(Token = "0x6004773")]
	public override void Deserialize(string str)
	{
	}
}
