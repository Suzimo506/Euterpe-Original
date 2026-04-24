using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007A9")]
public class DBConfigLocalCollabBundle : BaseDBConfigObject
{
	[Token(Token = "0x4002891")]
	[FieldOffset(Offset = "0x38")]
	private List<LocalCollabBundle> m_Items;

	[Token(Token = "0x170006CA")]
	protected List<LocalCollabBundle> m_List
	{
		[Token(Token = "0x6004712")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004713")]
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		private set
		{
		}
	}

	[Token(Token = "0x6004714")]
	[Address(RVA = "0x6FBF40", Offset = "0x6FA740", Length = "0x105")]
	public override void Deserialize(string str)
	{
	}

	[Token(Token = "0x6004715")]
	[Address(RVA = "0x6FC050", Offset = "0x6FA850", Length = "0x5A")]
	public LocalCollabBundle GetLocalPackageGroupInfoByListIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x6004716")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public DBConfigLocalCollabBundle()
	{
	}
}
