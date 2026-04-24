using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000783")]
public class DBConfig
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40027BC")]
	private Dictionary<string, BaseDBConfigObject> m_ConfigDic;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40027BD")]
	private List<BaseDataObject> m_MaskObject;

	[Address(RVA = "0x9CB310", Offset = "0x9C9B10", Length = "0x2D2")]
	[Token(Token = "0x6004662")]
	public void FindAllObject<T>(List<KeyValuePair<string, T>> buffer) where T : BaseDBConfigObject
	{
	}

	[Address(RVA = "0x7012C0", Offset = "0x6FFAC0", Length = "0x76")]
	[Token(Token = "0x6004663")]
	public void AddDBConfigObject(string name, BaseDBConfigObject obj)
	{
	}

	[Address(RVA = "0x7014A0", Offset = "0x6FFCA0", Length = "0x62")]
	[Token(Token = "0x6004664")]
	public bool GetDBConfigObject(string name, out BaseDBConfigObject obj)
	{
		obj = null;
		return default(bool);
	}

	[Address(RVA = "0x701510", Offset = "0x6FFD10", Length = "0x52")]
	[Token(Token = "0x6004665")]
	public bool RemoveDBConfigObject(string name)
	{
		return default(bool);
	}

	[Address(RVA = "0x701340", Offset = "0x6FFB40", Length = "0x6F")]
	[Token(Token = "0x6004666")]
	public void AddMaskObject(BaseDataObject maskObj)
	{
	}

	[Token(Token = "0x6004667")]
	[Address(RVA = "0x701570", Offset = "0x6FFD70", Length = "0x52")]
	public void RemoveMaskObject(BaseDataObject maskObj)
	{
	}

	[Token(Token = "0x6004668")]
	[Address(RVA = "0x7013B0", Offset = "0x6FFBB0", Length = "0xE6")]
	public void ClearAllMask()
	{
	}

	[Token(Token = "0x6004669")]
	[Address(RVA = "0x7015D0", Offset = "0x6FFDD0", Length = "0x96")]
	public DBConfig()
	{
	}
}
