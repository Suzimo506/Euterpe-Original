using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007AB")]
public class DBConfigCollabBundle : BaseDBConfigLocalObject<DBConfigLocalCollabBundle, LocalCollabBundle>
{
	[Token(Token = "0x4002894")]
	[FieldOffset(Offset = "0x40")]
	private List<CollabBundle> m_Items;

	[Token(Token = "0x170006CB")]
	protected List<CollabBundle> list
	{
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		[Token(Token = "0x6004718")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004719")]
		[Address(RVA = "0x6F4390", Offset = "0x6F2B90", Length = "0x36")]
		private set
		{
		}
	}

	[Token(Token = "0x600471A")]
	[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
	public List<CollabBundle> GetAllCollabBundleData()
	{
		return null;
	}

	[Token(Token = "0x600471B")]
	[Address(RVA = "0x6F72D0", Offset = "0x6F5AD0", Length = "0x5A")]
	public CollabBundle GetCollabBundleByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x600471C")]
	[Address(RVA = "0x6F71C0", Offset = "0x6F59C0", Length = "0x100")]
	public override void Deserialize(string str)
	{
	}

	[Address(RVA = "0x6F7330", Offset = "0x6F5B30", Length = "0x38")]
	[Token(Token = "0x600471D")]
	public DBConfigCollabBundle()
	{
		((BaseDBConfigLocalObject<, >)(object)this)._002Ector();
	}
}
