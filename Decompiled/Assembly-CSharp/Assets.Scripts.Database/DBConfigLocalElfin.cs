using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007C5")]
public class DBConfigLocalElfin : BaseDBConfigObject
{
	[Token(Token = "0x4002906")]
	[FieldOffset(Offset = "0x38")]
	private List<LocalElfinInfo> m_Items;

	[Token(Token = "0x170006FF")]
	protected List<LocalElfinInfo> list
	{
		[Token(Token = "0x6004798")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004799")]
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		private set
		{
		}
	}

	[Token(Token = "0x600479A")]
	[Address(RVA = "0x6FC790", Offset = "0x6FAF90", Length = "0x7A")]
	public DBConfigLocalElfin()
	{
	}

	[Token(Token = "0x600479B")]
	[Address(RVA = "0x6FC610", Offset = "0x6FAE10", Length = "0x100")]
	public override void Deserialize(string str)
	{
	}

	[Token(Token = "0x600479C")]
	[Address(RVA = "0x6FC720", Offset = "0x6FAF20", Length = "0x6B")]
	public LocalElfinInfo GetInfoByIndex(int index)
	{
		return null;
	}
}
