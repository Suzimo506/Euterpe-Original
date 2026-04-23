using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007AD")]
public class DBConfigLocalCollectionBundle : BaseDBConfigObject
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002898")]
	private List<LocalCollectionBundle> m_Items;

	[Token(Token = "0x170006CC")]
	protected List<LocalCollectionBundle> m_List
	{
		[Token(Token = "0x6004720")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004721")]
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		private set
		{
		}
	}

	[Token(Token = "0x600471F")]
	[Address(RVA = "0x6FC220", Offset = "0x6FAA20", Length = "0x7D")]
	public DBConfigLocalCollectionBundle()
	{
	}

	[Token(Token = "0x6004722")]
	[Address(RVA = "0x6FC0B0", Offset = "0x6FA8B0", Length = "0x105")]
	public override void Deserialize(string str)
	{
	}

	[Token(Token = "0x6004723")]
	[Address(RVA = "0x6FC1C0", Offset = "0x6FA9C0", Length = "0x5A")]
	public LocalCollectionBundle GetLocalPackageGroupInfoByListIndex(int index)
	{
		return null;
	}
}
