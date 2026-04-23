using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000784")]
public abstract class BaseDBConfigLocalObject<T, U> : BaseDBConfigObject where T : BaseDBConfigObject, new()
{
	[Token(Token = "0x40027BE")]
	[FieldOffset(Offset = "0x0")]
	protected Dictionary<int, T> m_LocalDic;

	[Token(Token = "0x600466A")]
	[Address(RVA = "0x135AF50", Offset = "0x1359750", Length = "0x105")]
	public override bool DeserializeLocal(string fileName, string str, int language)
	{
		return default(bool);
	}

	[Token(Token = "0x600466B")]
	[Address(RVA = "0x135BA40", Offset = "0x135A240", Length = "0xF1")]
	protected void RemoveLocal(int language, bool removeDataBase = false)
	{
	}

	[Address(RVA = "0x135B060", Offset = "0x1359860", Length = "0x9A")]
	[Token(Token = "0x600466C")]
	public void GetAllLocal(List<T> buffer)
	{
	}

	[Token(Token = "0x600466D")]
	[Address(RVA = "0x135B520", Offset = "0x1359D20", Length = "0x41E")]
	public T GetLocal(int language = 0)
	{
		return null;
	}

	[Token(Token = "0x600466E")]
	[Address(RVA = "0x135BB40", Offset = "0x135A340", Length = "0x8A")]
	protected BaseDBConfigLocalObject()
	{
	}
}
