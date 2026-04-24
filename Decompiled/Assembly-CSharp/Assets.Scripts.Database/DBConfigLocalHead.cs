using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007D2")]
public class DBConfigLocalHead : BaseDBConfigObject
{
	[Token(Token = "0x4002929")]
	[FieldOffset(Offset = "0x38")]
	private List<LocalHeadInfo> m_Items;

	[Token(Token = "0x1700070A")]
	protected List<LocalHeadInfo> list
	{
		[Token(Token = "0x60047C9")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60047CA")]
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		private set
		{
		}
	}

	[Token(Token = "0x60047CB")]
	[Address(RVA = "0x6FCDF0", Offset = "0x6FB5F0", Length = "0x7A")]
	public DBConfigLocalHead()
	{
	}

	[Address(RVA = "0x6FCC70", Offset = "0x6FB470", Length = "0x100")]
	[Token(Token = "0x60047CC")]
	public override void Deserialize(string str)
	{
	}

	[Address(RVA = "0x6FCD80", Offset = "0x6FB580", Length = "0x6B")]
	[Token(Token = "0x60047CD")]
	public LocalHeadInfo GetInfoByIndex(int index)
	{
		return null;
	}
}
