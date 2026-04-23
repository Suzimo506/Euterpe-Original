using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007C9")]
public class DBConfigLocalFailBarrage : BaseDBConfigObject
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400290C")]
	private List<FailBarrageLocalConfig> m_Items;

	[Token(Token = "0x17000703")]
	protected List<FailBarrageLocalConfig> list
	{
		[Token(Token = "0x60047AD")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60047AE")]
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		private set
		{
		}
	}

	[Address(RVA = "0x6FC920", Offset = "0x6FB120", Length = "0x141")]
	[Token(Token = "0x60047AC")]
	public bool GetFailBarrage(int roleIndex, List<string> buffer)
	{
		return default(bool);
	}

	[Address(RVA = "0x6FC810", Offset = "0x6FB010", Length = "0x105")]
	[Token(Token = "0x60047AF")]
	public override void Deserialize(string str)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60047B0")]
	public DBConfigLocalFailBarrage()
	{
	}
}
