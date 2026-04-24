using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007F8")]
public class DBConfigLocalTip : BaseDBConfigObject
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400299E")]
	private Dictionary<string, string> m_Items;

	[Token(Token = "0x17000739")]
	public override int count
	{
		[Address(RVA = "0x6FD740", Offset = "0x6FBF40", Length = "0x43")]
		[Token(Token = "0x6004862")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6004863")]
	[Address(RVA = "0x6FD6C0", Offset = "0x6FBEC0", Length = "0x7A")]
	public DBConfigLocalTip()
	{
	}

	[Token(Token = "0x6004864")]
	[Address(RVA = "0x6FD5C0", Offset = "0x6FBDC0", Length = "0x79")]
	public override void Deserialize(string str)
	{
	}

	[Token(Token = "0x6004865")]
	[Address(RVA = "0x6FD640", Offset = "0x6FBE40", Length = "0x7C")]
	public string GetTip(string key)
	{
		return null;
	}
}
