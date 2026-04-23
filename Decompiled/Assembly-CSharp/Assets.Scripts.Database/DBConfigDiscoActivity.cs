using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007B9")]
public class DBConfigDiscoActivity : BaseDBConfigLocalObject<DBConfigLocalDiscoActivity, LocalDiscoActivityInfo>
{
	[Token(Token = "0x40028B7")]
	[FieldOffset(Offset = "0x40")]
	private List<DiscoActivityInfo> m_Items;

	[Token(Token = "0x170006DC")]
	protected List<DiscoActivityInfo> list
	{
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		[Token(Token = "0x6004755")]
		get
		{
			return null;
		}
		[Address(RVA = "0x6F4390", Offset = "0x6F2B90", Length = "0x36")]
		[Token(Token = "0x6004756")]
		private set
		{
		}
	}

	[Token(Token = "0x6004754")]
	[Address(RVA = "0x6F8AA0", Offset = "0x6F72A0", Length = "0x9C")]
	public DBConfigDiscoActivity()
	{
		((BaseDBConfigLocalObject<, >)(object)this)._002Ector();
	}

	[Address(RVA = "0x6F8780", Offset = "0x6F6F80", Length = "0x100")]
	[Token(Token = "0x6004757")]
	public override void Deserialize(string str)
	{
	}

	[Address(RVA = "0x6F8890", Offset = "0x6F7090", Length = "0x208")]
	[Token(Token = "0x6004758")]
	public bool IsDiscoActivityContains(int index, string uid)
	{
		return default(bool);
	}
}
