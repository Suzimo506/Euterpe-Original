using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x200078C")]
public class DBConfigLocalAlbums : BaseDBConfigObject
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40027ED")]
	private List<string> m_Items;

	[Token(Token = "0x170006B6")]
	protected List<string> list
	{
		[Token(Token = "0x60046A7")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60046A8")]
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		private set
		{
		}
	}

	[Token(Token = "0x60046A6")]
	[Address(RVA = "0x6FB8E0", Offset = "0x6FA0E0", Length = "0x5A")]
	public string GetLocalTitleByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x60046A9")]
	[Address(RVA = "0x6FB6D0", Offset = "0x6F9ED0", Length = "0x205")]
	public override void Deserialize(string str)
	{
	}

	[Token(Token = "0x60046AA")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public DBConfigLocalAlbums()
	{
	}
}
