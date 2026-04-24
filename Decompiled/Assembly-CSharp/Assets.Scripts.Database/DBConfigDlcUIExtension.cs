using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007C1")]
public class DBConfigDlcUIExtension : BaseDBConfigObject
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40028E8")]
	private List<DlcUIExtensionInfo> m_Items;

	[Token(Token = "0x170006FE")]
	protected List<DlcUIExtensionInfo> list
	{
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		[Token(Token = "0x600478F")]
		get
		{
			return null;
		}
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		[Token(Token = "0x6004790")]
		private set
		{
		}
	}

	[Token(Token = "0x600478E")]
	[Address(RVA = "0x6F9140", Offset = "0x6F7940", Length = "0x7A")]
	public DBConfigDlcUIExtension()
	{
	}

	[Address(RVA = "0x6F8FD0", Offset = "0x6F77D0", Length = "0x164")]
	[Token(Token = "0x6004791")]
	public DlcUIExtensionInfo GetDlcUIExtensionByJsonIndex(int jsonIndex)
	{
		return null;
	}

	[Address(RVA = "0x6F8EC0", Offset = "0x6F76C0", Length = "0x100")]
	[Token(Token = "0x6004792")]
	public override void Deserialize(string str)
	{
	}
}
