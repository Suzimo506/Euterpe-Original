using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000805")]
public class DBConfigLocalWelcome : BaseDBConfigObject
{
	[Token(Token = "0x40029D1")]
	[FieldOffset(Offset = "0x38")]
	private List<LocalWelcomeInfo> m_Items;

	[Token(Token = "0x17000745")]
	protected List<LocalWelcomeInfo> list
	{
		[Token(Token = "0x600489C")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		[Token(Token = "0x600489D")]
		private set
		{
		}
	}

	[Address(RVA = "0x6FDE60", Offset = "0x6FC660", Length = "0x7A")]
	[Token(Token = "0x600489B")]
	public DBConfigLocalWelcome()
	{
	}

	[Address(RVA = "0x6FDCE0", Offset = "0x6FC4E0", Length = "0x100")]
	[Token(Token = "0x600489E")]
	public override void Deserialize(string str)
	{
	}

	[Token(Token = "0x600489F")]
	[Address(RVA = "0x6FDDF0", Offset = "0x6FC5F0", Length = "0x6B")]
	public LocalWelcomeInfo GetInfoByIndex(int index)
	{
		return null;
	}
}
