using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000020")]
public class DataModelManager
{
	[Token(Token = "0x4000097")]
	private static DataModelManager s_Instance;

	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, DataModel> m_CachedDataModels;

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x912D30", Offset = "0x911530", Length = "0x221")]
	public static T GetModel<T>() where T : DataModel
	{
		return null;
	}

	[Address(RVA = "0x9CB5F0", Offset = "0x9C9DF0", Length = "0x106")]
	[Token(Token = "0x60000D2")]
	public static void RemoveDataModel<T>() where T : DataModel
	{
	}

	[Address(RVA = "0x46D130", Offset = "0x46B930", Length = "0x74")]
	[Token(Token = "0x60000D3")]
	public static void RemoveAllDataModel()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x18AB010", Offset = "0x18A9810", Length = "0x1BD")]
	public static bool ReleaseDataModel<T>()
	{
		return default(bool);
	}

	[Address(RVA = "0x46D260", Offset = "0x46BA60", Length = "0x69")]
	[Token(Token = "0x60000D5")]
	public DataModelManager()
	{
	}
}
