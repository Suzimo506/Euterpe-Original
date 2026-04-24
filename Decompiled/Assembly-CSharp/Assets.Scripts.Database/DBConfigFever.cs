using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007CE")]
public class DBConfigFever : BaseDBConfigLocalObject<DBConfigLocalFever, LocalFeverInfo>
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002919")]
	private List<FeverInfo> m_Items;

	[Token(Token = "0x17000706")]
	protected List<FeverInfo> list
	{
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		[Token(Token = "0x60047BE")]
		get
		{
			return null;
		}
		[Token(Token = "0x60047BF")]
		[Address(RVA = "0x6F4390", Offset = "0x6F2B90", Length = "0x36")]
		private set
		{
		}
	}

	[Token(Token = "0x17000707")]
	public int freeCount
	{
		[Token(Token = "0x60047C2")]
		[Address(RVA = "0x6FA1A0", Offset = "0x6F89A0", Length = "0x104")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60047BD")]
	[Address(RVA = "0x6FA100", Offset = "0x6F8900", Length = "0x9C")]
	public DBConfigFever()
	{
		((BaseDBConfigLocalObject<, >)(object)this)._002Ector();
	}

	[Token(Token = "0x60047C0")]
	[Address(RVA = "0x6F9ED0", Offset = "0x6F86D0", Length = "0x100")]
	public override void Deserialize(string str)
	{
	}

	[Token(Token = "0x60047C1")]
	[Address(RVA = "0x6F9FE0", Offset = "0x6F87E0", Length = "0x6B")]
	public FeverInfo GetFeverInfoByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x60047C3")]
	[Address(RVA = "0x6FA090", Offset = "0x6F8890", Length = "0x62")]
	public bool IsExchange(int index)
	{
		return default(bool);
	}

	[Address(RVA = "0x6FA050", Offset = "0x6F8850", Length = "0x3B")]
	[Token(Token = "0x60047C4")]
	public int GetItemsLength()
	{
		return default(int);
	}
}
