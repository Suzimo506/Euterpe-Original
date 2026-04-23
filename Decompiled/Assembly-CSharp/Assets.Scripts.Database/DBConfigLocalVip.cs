using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000800")]
public class DBConfigLocalVip : BaseDBConfigObject
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40029AB")]
	private List<LocalVip> m_Items;

	[Token(Token = "0x1700073E")]
	protected List<LocalVip> m_List
	{
		[Token(Token = "0x6004885")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		[Token(Token = "0x6004886")]
		private set
		{
		}
	}

	[Token(Token = "0x6004884")]
	[Address(RVA = "0x6FDC60", Offset = "0x6FC460", Length = "0x7D")]
	public DBConfigLocalVip()
	{
	}

	[Token(Token = "0x6004887")]
	[Address(RVA = "0x6FDB80", Offset = "0x6FC380", Length = "0xD0")]
	public string GetLocalVipTitleByUid(string uid)
	{
		return null;
	}

	[Token(Token = "0x6004888")]
	[Address(RVA = "0x6FDA60", Offset = "0x6FC260", Length = "0x112")]
	public LocalVip GetLocalVipByUid(string uid)
	{
		return default(LocalVip);
	}

	[Token(Token = "0x6004889")]
	[Address(RVA = "0x6FD9D0", Offset = "0x6FC1D0", Length = "0x83")]
	public override void Deserialize(string str)
	{
	}
}
