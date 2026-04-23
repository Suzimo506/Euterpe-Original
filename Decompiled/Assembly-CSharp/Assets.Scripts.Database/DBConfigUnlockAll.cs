using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007FE")]
public class DBConfigUnlockAll : BaseDBConfigObject
{
	[Token(Token = "0x40029A7")]
	[FieldOffset(Offset = "0x38")]
	private List<UnlockAllInfo> m_Items;

	[Token(Token = "0x1700073D")]
	protected List<UnlockAllInfo> list
	{
		[Token(Token = "0x600487B")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x600487C")]
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		private set
		{
		}
	}

	[Address(RVA = "0x7003B0", Offset = "0x6FEBB0", Length = "0x8C")]
	[Token(Token = "0x600487D")]
	public DBConfigUnlockAll()
	{
	}

	[Address(RVA = "0x700320", Offset = "0x6FEB20", Length = "0x88")]
	[Token(Token = "0x600487E")]
	public string GetUidByIndex(int i)
	{
		return null;
	}

	[Token(Token = "0x600487F")]
	[Address(RVA = "0x700000", Offset = "0x6FE800", Length = "0x7C")]
	public UnlockAllInfo GetInfoByIndex(int i)
	{
		return null;
	}

	[Token(Token = "0x6004880")]
	[Address(RVA = "0x700080", Offset = "0x6FE880", Length = "0xD8")]
	public UnlockAllInfo GetInfoByUid(string uid)
	{
		return null;
	}

	[Token(Token = "0x6004881")]
	[Address(RVA = "0x6FFDE0", Offset = "0x6FE5E0", Length = "0x211")]
	public UnlockAllInfo FindMinimumGapInfo(decimal price)
	{
		return null;
	}

	[Token(Token = "0x6004882")]
	[Address(RVA = "0x700160", Offset = "0x6FE960", Length = "0x1B0")]
	public UnlockAllInfo GetMaxPriceInfo()
	{
		return null;
	}

	[Token(Token = "0x6004883")]
	[Address(RVA = "0x6FFCD0", Offset = "0x6FE4D0", Length = "0x100")]
	public override void Deserialize(string str)
	{
	}
}
