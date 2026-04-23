using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007CA")]
public class DBConfigFailBarrage : BaseDBConfigLocalObject<DBConfigLocalFailBarrage, FailBarrageLocalConfig>
{
	[Token(Token = "0x400290D")]
	[FieldOffset(Offset = "0x40")]
	private List<FailBarrageConfig> m_Items;

	[Token(Token = "0x17000704")]
	protected List<FailBarrageConfig> list
	{
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		[Token(Token = "0x60047B2")]
		get
		{
			return null;
		}
		[Address(RVA = "0x6F4390", Offset = "0x6F2B90", Length = "0x36")]
		[Token(Token = "0x60047B3")]
		private set
		{
		}
	}

	[Token(Token = "0x60047B1")]
	[Address(RVA = "0x6F9E30", Offset = "0x6F8630", Length = "0x9C")]
	public DBConfigFailBarrage()
	{
		((BaseDBConfigLocalObject<, >)(object)this)._002Ector();
	}

	[Token(Token = "0x60047B4")]
	[Address(RVA = "0x6F9D50", Offset = "0x6F8550", Length = "0xD7")]
	public FailBarrageConfig GetBarrageConfigByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x60047B5")]
	[Address(RVA = "0x6F9C40", Offset = "0x6F8440", Length = "0x100")]
	public override void Deserialize(string str)
	{
	}
}
