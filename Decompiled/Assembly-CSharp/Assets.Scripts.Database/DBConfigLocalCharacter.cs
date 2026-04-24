using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007A1")]
public class DBConfigLocalCharacter : BaseDBConfigObject
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002883")]
	private List<LocalCharacterInfo> m_Items;

	[Token(Token = "0x170006C4")]
	protected List<LocalCharacterInfo> list
	{
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		[Token(Token = "0x60046EE")]
		get
		{
			return null;
		}
		[Token(Token = "0x60046EF")]
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		private set
		{
		}
	}

	[Token(Token = "0x60046ED")]
	[Address(RVA = "0x6FBEC0", Offset = "0x6FA6C0", Length = "0x7A")]
	public DBConfigLocalCharacter()
	{
	}

	[Address(RVA = "0x6FBD40", Offset = "0x6FA540", Length = "0x100")]
	[Token(Token = "0x60046F0")]
	public override void Deserialize(string str)
	{
	}

	[Token(Token = "0x60046F1")]
	[Address(RVA = "0x6FBE50", Offset = "0x6FA650", Length = "0x6B")]
	public LocalCharacterInfo GetInfoByIndex(int index)
	{
		return null;
	}
}
