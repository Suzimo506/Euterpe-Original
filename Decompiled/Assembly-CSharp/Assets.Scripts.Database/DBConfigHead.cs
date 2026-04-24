using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007D3")]
public class DBConfigHead : BaseDBConfigLocalObject<DBConfigLocalHead, LocalHeadInfo>
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400292A")]
	private List<HeadInfo> m_Items;

	[Token(Token = "0x400292B")]
	[FieldOffset(Offset = "0x48")]
	private List<int> m_NeedPurchaseHeadIndexs;

	[Token(Token = "0x1700070B")]
	protected List<HeadInfo> list
	{
		[Token(Token = "0x60047CE")]
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60047CF")]
		[Address(RVA = "0x6F4390", Offset = "0x6F2B90", Length = "0x36")]
		private set
		{
		}
	}

	[Token(Token = "0x60047D0")]
	[Address(RVA = "0x6FA630", Offset = "0x6F8E30", Length = "0xC9")]
	public DBConfigHead()
	{
		((BaseDBConfigLocalObject<, >)(object)this)._002Ector();
	}

	[Token(Token = "0x60047D1")]
	[Address(RVA = "0x6FA2B0", Offset = "0x6F8AB0", Length = "0x161")]
	public override void Deserialize(string str)
	{
	}

	[Token(Token = "0x60047D2")]
	[Address(RVA = "0x6FA5C0", Offset = "0x6F8DC0", Length = "0x6B")]
	public HeadInfo GetHeadInfoByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x60047D3")]
	[Address(RVA = "0x6FA4F0", Offset = "0x6F8CF0", Length = "0xC4")]
	public void GetAllNeedPurchaseHeadIndexs(List<int> indexs)
	{
	}

	[Address(RVA = "0x6FA420", Offset = "0x6F8C20", Length = "0xC9")]
	[Token(Token = "0x60047D4")]
	public void GetAllHeadInfo(List<HeadInfo> infos)
	{
	}
}
