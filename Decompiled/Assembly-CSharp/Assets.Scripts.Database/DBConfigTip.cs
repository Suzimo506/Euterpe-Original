using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007F9")]
public class DBConfigTip : BaseDBConfigLocalObject<DBConfigLocalTip, KeyValuePair<string, string>>
{
	[Token(Token = "0x400299F")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<string, string> m_Items;

	[Token(Token = "0x1700073A")]
	public override int count
	{
		[Address(RVA = "0x6FF9A0", Offset = "0x6FE1A0", Length = "0x43")]
		[Token(Token = "0x6004867")]
		get
		{
			return default(int);
		}
	}

	[Address(RVA = "0x6FF810", Offset = "0x6FE010", Length = "0xE6")]
	[Token(Token = "0x6004866")]
	public static string GetTip(string key)
	{
		return null;
	}

	[Address(RVA = "0x6FF900", Offset = "0x6FE100", Length = "0x9C")]
	[Token(Token = "0x6004868")]
	public DBConfigTip()
	{
		((BaseDBConfigLocalObject<, >)(object)this)._002Ector();
	}

	[Address(RVA = "0x6FF790", Offset = "0x6FDF90", Length = "0x79")]
	[Token(Token = "0x6004869")]
	public override void Deserialize(string str)
	{
	}
}
