using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000788")]
public class DBConfigLocalALBUM : BaseDBConfigObject
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40027C8")]
	private List<LocalALBUMInfo> m_Items;

	[Token(Token = "0x170006AC")]
	protected List<LocalALBUMInfo> List
	{
		[Token(Token = "0x6004685")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004686")]
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		private set
		{
		}
	}

	[Address(RVA = "0x6FB650", Offset = "0x6F9E50", Length = "0x78")]
	[Token(Token = "0x6004683")]
	public DBConfigLocalALBUM()
	{
	}

	[Token(Token = "0x6004684")]
	[Address(RVA = "0x6FB5F0", Offset = "0x6F9DF0", Length = "0x5A")]
	public LocalALBUMInfo GetLocalAlbumInfoByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x6004687")]
	[Address(RVA = "0x6FB4E0", Offset = "0x6F9CE0", Length = "0x105")]
	public override void Deserialize(string str)
	{
	}
}
