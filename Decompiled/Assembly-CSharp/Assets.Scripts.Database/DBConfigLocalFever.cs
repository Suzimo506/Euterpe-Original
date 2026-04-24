using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007CD")]
public class DBConfigLocalFever : BaseDBConfigObject
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002918")]
	private List<LocalFeverInfo> m_Items;

	[Token(Token = "0x17000705")]
	protected List<LocalFeverInfo> list
	{
		[Token(Token = "0x60047B9")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60047BA")]
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		private set
		{
		}
	}

	[Address(RVA = "0x6FCBF0", Offset = "0x6FB3F0", Length = "0x7A")]
	[Token(Token = "0x60047B8")]
	public DBConfigLocalFever()
	{
	}

	[Token(Token = "0x60047BB")]
	[Address(RVA = "0x6FCA70", Offset = "0x6FB270", Length = "0x100")]
	public override void Deserialize(string str)
	{
	}

	[Address(RVA = "0x6FCB80", Offset = "0x6FB380", Length = "0x6B")]
	[Token(Token = "0x60047BC")]
	public LocalFeverInfo GetInfoByIndex(int index)
	{
		return null;
	}
}
